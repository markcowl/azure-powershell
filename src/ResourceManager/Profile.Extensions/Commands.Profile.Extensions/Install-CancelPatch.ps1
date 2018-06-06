#  ----------------------------------------------------------------------------------
# 
#  Copyright Microsoft Corporation
#  Licensed under the Apache License, Version 2.0 (the "License");
#  you may not use this file except in compliance with the License.
#  You may obtain a copy of the License at
#  http:# www.apache.org/licenses/LICENSE-2.0
#  Unless required by applicable law or agreed to in writing, software
#  distributed under the License is distributed on an "AS IS" BASIS,
#  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
#  See the License for the specific language governing permissions and
#  limitations under the License.
#  ----------------------------------------------------------------------------------

function Install-CancelPatch 
{
    [CmdletBinding()]
	param()

    process 
    {
        $handler = New-Object -TypeName Microsoft.Azure.Commands.Profile.Extensions.CancelRetryDelegatingHandler -Property @{WaitInterval=[System.TimeSpan]::FromSeconds(10); MaxTries=3}
        [Microsoft.Azure.Commands.Common.Authentication.AzureSession]::Instance.ClientFactory.AddHandler($handler)
    }
}
