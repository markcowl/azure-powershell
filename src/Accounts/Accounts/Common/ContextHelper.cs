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

using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Azure.Commands.Profile.Common
{
    public static class ContextHelper
    {
        /// <summary>
        /// Filter a set of contexts by one of its properties
        /// </summary>
        /// <param name="contexts">The contexts to filter</param>
        /// <param name="parameterName">The incoming parameter name to filter by</param>
        /// <param name="wordToComplete">The value of the incoming parameter</param>
        /// <param name="parameters">The bound parameters</param>
        /// <param name="targetValue">The name of the property to filter by</param>
        /// <param name="accessor">Value accessor for incoming Key/Value pairs</param>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<string, IAzureContext>> Filter(this IEnumerable<KeyValuePair<string, IAzureContext>> contexts, string parameterName, string wordToComplete, IDictionary parameters, string targetValue, params Func<KeyValuePair<string, IAzureContext>, string>[] accessor)
        {
            if (contexts != null)
            {
                WildcardPattern pattern = null;
                string valueString = null;
                if (parameters != null && parameters.Contains(targetValue))
                {
                    valueString = parameters[targetValue] as string;
                    if (!string.IsNullOrWhiteSpace(valueString))
                    {
                        if (!WildcardPattern.ContainsWildcardCharacters(valueString))
                        {
                            valueString = $"{valueString}*";
                        }

                        pattern = new WildcardPattern(valueString);
                    }
                }

                if (string.Equals(parameterName, targetValue, StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(wordToComplete))
                {
                    valueString = wordToComplete;
                    if (!WildcardPattern.ContainsWildcardCharacters(valueString))
                    {
                        valueString = $"{valueString}*";
                    }

                    pattern = new WildcardPattern(valueString);
                }

                if (pattern != null && accessor.Any())
                {
                    contexts = contexts.Where((pair) => accessor.Any(access => pattern.IsMatch(access(pair)) || valueString.StartsWith(access(pair), StringComparison.OrdinalIgnoreCase)));
                }
            }

            return contexts;
        }
    }
}
