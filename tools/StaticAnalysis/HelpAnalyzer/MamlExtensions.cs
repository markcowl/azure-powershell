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
using System.Text;
using System.Threading.Tasks;
using Markdown.MAML.Model.MAML;

namespace StaticAnalysis.HelpAnalyzer
{
    public static class MamlExtensions
    {
        /// <summary>
        /// Get the position of a parameter
        /// </summary>
        /// <param name="parameter">The parameter to check</param>
        /// <returns>The position of the parameter, or int.MaxValue if there is none</returns>
        public static string GetPosition(this MamlParameter parameter)
        {
            string result = null;
            int position;
            if (int.TryParse(parameter.Position, out position))
            {
                result = parameter.Position;
            }

            return result;
        }

        /// <summary>
        /// Return the attribute string representation of pipeline data status for the cmdlet
        /// </summary>
        /// <param name="parameter">The parameter to check</param>
        /// <returns>How the data matches values from the pipeline</returns>
        public static string GetPipelineData(this ParameterAttribute parameter)
        {
            if (parameter.ValueFromPipeline && parameter.ValueFromPipelineByPropertyName)
            {
                return "true (ByValue, ByPropertyName)";
            }
            else if (parameter.ValueFromPipeline)
            {
                return "true (ByValue)";
            }
            else if (parameter.ValueFromPipelineByPropertyName)
            {
                return "true (ByPropertyName)";
            }
            else
            {
                return "false";
            }
        }
    }
}
