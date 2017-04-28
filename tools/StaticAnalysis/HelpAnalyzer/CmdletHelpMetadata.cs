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
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Runtime.InteropServices;
using Markdown.MAML.Model.MAML;
using StaticAnalysis.help;

namespace StaticAnalysis.HelpAnalyzer
{
    [Serializable]
    public class CmdletHelpMetadata
    {
        const string DefaultParameterSet = "default";
        public static MamlCommand GetMamlCommand(Type cmdletType, CmdletAttribute attribute)
        {
            var command = new MamlCommand();
            command.Name = string.Format("{0}-{1}", attribute.VerbName, attribute.NounName);
            AddMamlOutputs(command, cmdletType);
            AddMamlParametersAndSyntax(command, cmdletType);
            return command;
        }

        private static void AddMamlParametersAndSyntax(MamlCommand command, Type cmdletType)
        {
            Dictionary<string, MamlSyntax> syntaxItems = new Dictionary<string, MamlSyntax>(StringComparer.OrdinalIgnoreCase);
            HashSet<string> parameterSets = GetParameterSets(cmdletType);
            foreach (var set in parameterSets)
            {
                syntaxItems.Add(set, new MamlSyntax());
            }

            foreach (var parameter in cmdletType.GetCmdletParameters())
            {
                foreach (var parameterData in parameter.GetAttributes<ParameterAttribute>())
                {
                    MamlParameter mamlParameter = CreateMamlParameter(parameter, parameterData);
                    syntaxItems[parameterData.ParameterSetName].Parameters.Add(mamlParameter);
                }
            }

            if (syntaxItems.ContainsKey(ParameterAttribute.AllParameterSets) && syntaxItems.Keys.Count > 1)
            {
                var allParametersItem = syntaxItems[ParameterAttribute.AllParameterSets];
                syntaxItems.Remove(ParameterAttribute.AllParameterSets);
                foreach (var syntaxItem in syntaxItems.Values)
                {
                    syntaxItem.Parameters.AddRange(allParametersItem.Parameters);
                }
            }

            foreach (var syntaxItem in syntaxItems.Values)
            {
                var newItem = new MamlSyntax();
                syntaxItem.Parameters.OrderBy(p => p.GetPosition()).ToList().ForEach(
                    o =>
                    {
                        newItem.Parameters.Add(o);
                        if (!command.Parameters.Any(p => string.Equals(p.Name, o.Name, StringComparison.OrdinalIgnoreCase)))
                        {
                            command.Parameters.Add(o);
                        }
                    });
                command.Syntax.Add(newItem);
            }
        }

        private static HashSet<string> GetParameterSets(Type cmdletType)
        {
            var parameterSets = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var parameter in cmdletType.GetCmdletParameters())
            {
                foreach (var parameterData in parameter.GetAttributes<ParameterAttribute>())
                {
                    var parameterSet = parameterData.ParameterSetName;
                    if (!parameterSets.Contains(parameterSet))
                    {
                        parameterSets.Add(parameterSet);
                    }
                }
            }

            return parameterSets;
        }

        private static MamlParameter CreateMamlParameter(PropertyInfo parameter, ParameterAttribute parameterData)
        {
            var result = new MamlParameter();
            result.Name = parameter.Name;
            if (parameter.HasAttribute<AliasAttribute>())
            {
                var aliases = parameter.GetAttributes<AliasAttribute>();
                result.Aliases = aliases.SelectMany(a => a.AliasNames).ToArray();
            }
            result.Position = parameterData.Position < 0 ? string.Empty : parameterData.Position.ToString();
            result.PipelineInput = parameterData.GetPipelineData();
            if (parameter.HasAttribute<ValidateSetAttribute>())
            {
                var validate = parameter.GetAttribute<ValidateSetAttribute>();
                result.ParameterValueGroup.AddRange(validate.ValidValues);
            }

            result.Description = parameterData.HelpMessage;
            result.Required = parameterData.Mandatory;
            result.Type = parameter.PropertyType.Name;
            result.ValueRequired = !(parameter.PropertyType is SwitchParameter);
            if (parameter.HasAttribute<PSDefaultValueAttribute>())
            {
                var defaultValue = parameter.GetAttribute<PSDefaultValueAttribute>();
                result.DefaultValue = defaultValue.Value.ToString();
            }

            if (parameter.HasAttribute<SupportsWildcardsAttribute>())
            {
                result.Globbing = true;
            }

            return result;
        }

        private static void AddMamlOutputs(MamlCommand command, Type cmdletType)
        {
            var outputAttributes = cmdletType.GetAttributes<OutputTypeAttribute>();
            foreach (var output in outputAttributes)
            {
                if (output.ParameterSetName != null && output.ParameterSetName.Any())
                {
                    foreach (var parameterSetName in output.ParameterSetName)
                    {
                        AddMamlOutputForParameterSet(command.Outputs, output, parameterSetName);
                    }
                }
                else
                {
                    AddMamlOutputForParameterSet(command.Outputs, output, null);
                }
            }
        }

        private static void AddMamlOutputForParameterSet(List<MamlInputOutput> outputs, OutputTypeAttribute output, string parameterSetName)
        {
            foreach (var typeName in output.Type)
            {
                outputs.Add(new MamlInputOutput
                {
                    Description = parameterSetName == ParameterAttribute.AllParameterSets? null : parameterSetName,
                    TypeName = typeName.Type.Name
                });
            }
        }
    }
}
