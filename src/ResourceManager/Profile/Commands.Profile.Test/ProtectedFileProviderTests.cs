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

using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Common.Authentication.Models;
using Microsoft.Azure.Commands.Common.Authentication.ResourceManager;
using Microsoft.Azure.Commands.Profile;
using Microsoft.Azure.Commands.ResourceManager.Common;
using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.WindowsAzure.Commands.Common.Test.Mocks;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Microsoft.WindowsAzure.Commands.Test.Utilities.Common;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Moq;
using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.ResourceManager.Profile.Test
{
    public class ProtectedFileProviderTests
    {
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void MultipleConcurrentReadsAllowed()
        {

        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void WriteAccessIsExclusive()
        {

        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void FileProviderThrowsOnInvalidInputs()
        {
            Assert.Throws(typeof(ArgumentNullException), () => ProtectedFileProvider.CreateFileProvider(string.Empty, FileProtection.SharedRead, null));
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => ProtectedFileProvider.CreateFileProvider(string.Empty, FileProtection.SharedRead, new MemoryDataStore()));

            Mock<IDataStore> store = new Mock<IDataStore>();
            store.Setup(d => d.FileExists(It.IsAny<string>())).Returns(true);
            store.Setup(d => d.OpenForExclusiveWrite(It.IsAny<string>())).Throws(new IOException("File is in use"));
            store.Setup(d => d.OpenForSharedRead(It.IsAny<string>())).Throws(new IOException("File is in use"));
            bool oldMockSupport = TestMockSupport.RunningMocked;
            TestMockSupport.RunningMocked = true;
            try
            {
                Assert.Throws<InvalidOperationException>(() => ProtectedFileProvider.CreateFileProvider("myFile.txt", FileProtection.SharedRead, store.Object).ProtectedStream);
                store.Verify(d => d.OpenForSharedRead(It.IsAny<string>()), Times.Exactly(3));
                Assert.Throws<InvalidOperationException>(() => ProtectedFileProvider.CreateFileProvider("myFile.txt", FileProtection.ExclusiveWrite, store.Object).ProtectedStream);
                store.Verify(d => d.OpenForExclusiveWrite(It.IsAny<string>()), Times.Exactly(3));
            }
            finally
            {
                TestMockSupport.RunningMocked = oldMockSupport;
            }
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void LockFailureThrowsGoodException()
        {

        }
    }
}
