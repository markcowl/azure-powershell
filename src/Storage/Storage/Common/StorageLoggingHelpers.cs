using Azure.Core.Diagnostics;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.WindowsAzure.Commands.Storage.Blob.Cmdlet;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Microsoft.WindowsAzure.Commands.Storage.Common
{
    public  class StorageLoggingHelpers : IDisposable
    {

        GetAzureStorageContainerCommand _cmdlet;
        AzureEventSourceListener _listener;

        public StorageLoggingHelpers(GetAzureStorageContainerCommand cmdlet)
        {
            _cmdlet = cmdlet;
        }

        public void HandleLoggingEvent(EventWrittenEventArgs args, string formattedMessage)
        {
            _cmdlet.Queue.Enqueue(formattedMessage);
        }

        public void CreateListener(AzureDataCmdlet cmdlet)
        {
            AzureEventSourceListener.CreateConsoleLogger();
            _listener = new AzureEventSourceListener(HandleLoggingEvent, EventLevel.Informational);
        }

        public void Dispose()
        {
             Dispose(true);
        }

        public virtual void Dispose( bool disposing)
        {
            if (disposing)
            {
                _listener?.Dispose();
                _listener = null;
            }
        }
    }
}
