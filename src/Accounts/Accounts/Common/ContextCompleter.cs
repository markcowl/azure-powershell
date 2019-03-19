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
using Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Profile.Models;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Language;

namespace Microsoft.Azure.Commands.Profile.Common
{
    public class ContextCompleterImpl : IArgumentCompleter
    {
        public IEnumerable<CompletionResult> CompleteArgument(string commandName, string parameterName, string wordToComplete, CommandAst commandAst, IDictionary fakeBoundParameters)
        {
            var contexts = GetAvailableContexts(parameterName, wordToComplete, fakeBoundParameters);
            IEnumerable<CompletionResult> values;
            switch(parameterName)
            {
                case "Name":
                    values = contexts.Select(p => new CompletionResult($"'{p.Key}'"));
                    break;
                case "Subscription":
                    values = contexts.Select(p => new CompletionResult($"'{p.Value?.Subscription?.Name}'"));
                    break;
                case "Account":
                    values = contexts.Select(p => new CompletionResult($"'{p.Value?.Account?.Id}'"));
                    break;
                default:
                    values = new List<CompletionResult>(0);
                    break;
            }

            return values;
        }

        static IEnumerable<KeyValuePair<string, IAzureContext>> GetAvailableContexts(string parameterName, string wordToComplete, IDictionary parameters)
        {
            return GetProfile(parameters)?.Contexts
                ?.Filter(parameterName, wordToComplete, parameters, "Name", c => c.Key)
                ?.Filter(parameterName, wordToComplete, parameters, "Subscription", c => c.Value?.Subscription?.Id, con => con.Value?.Subscription?.Name)
                ?.Filter(parameterName, wordToComplete, parameters, "Account", c => c.Value?.Account?.Id);
        }

        static AzureRmProfile GetProfile(IDictionary parameters)
        {
            var profile = AzureRmProfileProvider.Instance.GetProfile<AzureRmProfile>();
            if (parameters != null && parameters.Contains("DefaultProfile"))
            {
                var converter = new AzureContextConverter();
                var passedProfile = parameters["DefaultProfile"];
                if (converter.CanConvertFrom(passedProfile, typeof(IAzureContextContainer)))
                {
                    var converted = converter.ConvertFrom(passedProfile, typeof(IAzureContextContainer), CultureInfo.InvariantCulture, true) as AzureRmProfile;
                    profile = converted?? profile;
                }
            }

            return profile;
        }

    }
}
