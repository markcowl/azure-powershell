// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Markdown.MAML.Model.MAML;
using Markdown.MAML.Parser;
using Markdown.MAML.Renderer;
using Markdown.MAML.Transformer;

namespace StaticAnalysis.HelpAnalyzer
{
    /// <summary>
    /// Static analyzer for PowerShell Help
    /// </summary>
    public class HelpAnalyzer : IStaticAnalyzer
    {
        const int MissingHelp = 6050;
        public HelpAnalyzer()
        {
            Name = "Help Analyzer";
        }
        public AnalysisLogger Logger { get; set; }
        public string Name { get; private set; }

        private AppDomain _appDomain;

        /// <summary>
        /// Given a set of directory paths containing PowerShell module folders, analyze the help 
        /// in the module folders and report any issues
        /// </summary>
        /// <param name="scopes"></param>
        public void Analyze(IEnumerable<string> scopes)
        {
            var savedDirectory = Directory.GetCurrentDirectory();
            var processedHelpFiles = new List<string>();
            var helpLogger = Logger.CreateLogger<HelpIssue>("HelpIssues.csv");
            foreach (var baseDirectory in scopes.Where(s => Directory.Exists(Path.GetFullPath(s))))
            {
                foreach (var directory in Directory.EnumerateDirectories(Path.GetFullPath(baseDirectory)))
                {
                    var helpFiles = Directory.EnumerateFiles(directory, "*.dll-Help.xml")
                        .Where(f => !processedHelpFiles.Contains(Path.GetFileName(f),
                            StringComparer.OrdinalIgnoreCase)).ToList();
                    if (helpFiles.Any())
                    {
                        Directory.SetCurrentDirectory(directory);
                        foreach (var helpFile in helpFiles)
                        {
                            var cmdletFile = helpFile.Substring(0, helpFile.Length - "-Help.xml".Length);
                            var helpFileName = Path.GetFileName(helpFile);
                            var cmdletFileName = Path.GetFileName(cmdletFile);
                            if (File.Exists(cmdletFile))
                            {
                                processedHelpFiles.Add(helpFileName);
                                helpLogger.Decorator.AddDecorator((h) =>
                                {
                                    h.HelpFile = helpFileName;
                                    h.Assembly = cmdletFileName;
                                }, "Cmdlet");
                                var proxy = EnvironmentHelpers.CreateProxy<CmdletLoader>(directory, out _appDomain);
                                var cmdlets = proxy.GetCmdlets(cmdletFile);
                                IList<MamlCommand> markdownHelp = GetMarkdownHelp(Path.Combine(directory, "help"));
                                if (markdownHelp != null)
                                {
                                    IList<MamlCommand> combinedHelp = CombineHelp(cmdlets, markdownHelp);
                                    WriteMamlHelp(combinedHelp, helpFile);
                                }
                                var helpRecords = CmdletHelpParser.GetHelpTopics(helpFile, helpLogger);
                                ValidateHelpRecords(cmdlets, helpRecords, helpLogger);
                                helpLogger.Decorator.Remove("Cmdlet");
                                AppDomain.Unload(_appDomain);
                            }
                        }

                        Directory.SetCurrentDirectory(savedDirectory);
                    }
                }
            }
        }

        private void WriteMamlHelp(IList<MamlCommand> combinedHelp, string helpFile)
        {
            if (combinedHelp != null && combinedHelp.Count > 0)
            {
                var renderer = new MamlRenderer();
                File.WriteAllText(helpFile, renderer.MamlModelToString(combinedHelp));
                Logger.WriteMessage("Writing new help file {0}", helpFile);
            }
        }

        private IList<MamlCommand> CombineHelp(IList<MamlCommand> cmdlets, IList<MamlCommand> markdownHelp)
        {
            foreach (var cmdlet in cmdlets)
            {
                var matchingHelp =
                    markdownHelp.FirstOrDefault(
                        h => string.Equals(cmdlet.Name, h.Name, StringComparison.OrdinalIgnoreCase));
                if (matchingHelp != null)
                {
                    cmdlet.Description = matchingHelp.Description;
                    cmdlet.Examples.AddRange(matchingHelp.Examples);
                    cmdlet.Extent = matchingHelp.Extent;
                    cmdlet.Links.AddRange(matchingHelp.Links);
                    cmdlet.Notes = matchingHelp.Notes;
                    cmdlet.Synopsis = matchingHelp.Synopsis;
                    MergeCmdletParametersAndSyntax(cmdlet, matchingHelp);
                }
                else
                {
                    Logger.WriteError("Could not find matching Markdown help for cmdlet {0}", cmdlet.Name);
                }
            }

            return cmdlets;
        }

        private void MergeCmdletParametersAndSyntax(MamlCommand cmdlet, MamlCommand matchingHelp)
        {
            foreach (var parameter in matchingHelp.Parameters)
            {
                if (cmdlet.Syntax.SelectMany(s => s.Parameters)
                        .Any(p => string.Equals(p.Name, parameter.Name, StringComparison.OrdinalIgnoreCase)))
                {
                    foreach (var matchingParameter in
                       cmdlet.Syntax.SelectMany(s => s.Parameters)
                           .Where(p => string.Equals(p.Name, parameter.Name, StringComparison.OrdinalIgnoreCase)))
                    {
                        matchingParameter.Description = parameter.Description;
                        matchingParameter.Extent = parameter.Extent;
                        matchingParameter.AttributesText = parameter.AttributesText;
                    }
                }
                else
                {
                    Logger.WriteError("Cmdlet{0}: Unable to find matching parameter {1}", cmdlet.Name, parameter.Name);
                }
            }
        }

        private IList<MamlCommand> GetMarkdownHelp(string directoryPath)
        {
            List<MamlCommand> result = null;
            if (Directory.Exists(directoryPath))
            {
                result = new List<MamlCommand>();
                foreach (var filePath in Directory.GetFiles(directoryPath))
                {
                    var parser = new MarkdownParser();
                    var node = parser.ParseString(File.ReadAllText(filePath));
                    var transformer = new ModelTransformer();
                    result.AddRange(transformer.NodeModelToMamlModel(node));
                }
            }
            else
            {
                Logger.WriteMessage("No help files found in {0}, skipping", directoryPath);
            }

            return result;
        }

        private void ValidateHelpRecords(IList<MamlCommand> cmdlets, IList<string> helpRecords,
            ReportLogger<HelpIssue> helpLogger)
        {
            foreach (var cmdlet in cmdlets)
            {
                //if (!helpRecords.Contains(cmdlet.CmdletName, StringComparer.OrdinalIgnoreCase))
                //{
                //    helpLogger.LogRecord(new HelpIssue
                //    {
                //        Target = cmdlet.ClassName,
                //        Severity = 1,
                //        ProblemId = MissingHelp,
                //        Description = string.Format("Help missing for cmdlet {0} implemented by class {1}", 
                //        cmdlet.CmdletName, cmdlet.ClassName),
                //        Remediation = string.Format("Add Help record for cmdlet {0} to help file.", cmdlet.CmdletName)
                //    });
                //}
            }
        }
    }
}
