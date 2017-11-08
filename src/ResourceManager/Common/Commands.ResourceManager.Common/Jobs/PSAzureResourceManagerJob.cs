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
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.ResourceManager.Common.Jobs
{
    public class PSAzureResourceManagerJob : Job2
    {
        public override bool HasMoreData
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string Location
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string StatusMessage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void ResumeJob()
        {
            throw new NotImplementedException();
        }

        public override void ResumeJobAsync()
        {
            throw new NotImplementedException();
        }

        public override void StartJob()
        {
            throw new NotImplementedException();
        }

        public override void StartJobAsync()
        {
            throw new NotImplementedException();
        }

        public override void StopJob()
        {
            throw new NotImplementedException();
        }

        public override void StopJob(bool force, string reason)
        {
            throw new NotImplementedException();
        }

        public override void StopJobAsync()
        {
            throw new NotImplementedException();
        }

        public override void StopJobAsync(bool force, string reason)
        {
            throw new NotImplementedException();
        }

        public override void SuspendJob()
        {
            throw new NotImplementedException();
        }

        public override void SuspendJob(bool force, string reason)
        {
            throw new NotImplementedException();
        }

        public override void SuspendJobAsync()
        {
            throw new NotImplementedException();
        }

        public override void SuspendJobAsync(bool force, string reason)
        {
            throw new NotImplementedException();
        }

        public override void UnblockJob()
        {
            throw new NotImplementedException();
        }

        public override void UnblockJobAsync()
        {
            throw new NotImplementedException();
        }
    }
}
