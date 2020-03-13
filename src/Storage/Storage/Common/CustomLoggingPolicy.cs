using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Microsoft.WindowsAzure.Commands.Common;
using Microsoft.WindowsAzure.Commands.Storage.Blob.Cmdlet;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.WindowsAzure.Commands.Storage.Common
{
    public class CustomLoggingPolicy : HttpPipelinePolicy
    {
        GetAzureStorageContainerCommand _cmdlet;
        public CustomLoggingPolicy(GetAzureStorageContainerCommand cmdlet)
        {
            _cmdlet = cmdlet;
        }

        public override void Process(HttpMessage message,  ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            if (message.HasResponse)
            {
                _cmdlet.Queue.Enqueue(FormatResponse(message.Response));
            }
            else
            {
                _cmdlet.Queue.Enqueue(FormatRequest(message.Request));
            }

            ProcessNext(message, pipeline);
        }

        public async override ValueTask ProcessAsync(HttpMessage message,  ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            if (message.HasResponse)
            {
                _cmdlet.DebugMessages.Enqueue(FormatResponse(message.Response));
            }
            else
            {
                _cmdlet.DebugMessages.Enqueue(FormatRequest(message.Request));
            }

            await ProcessNextAsync(message, pipeline);
        }

        public static string FormatRequest(Request request)
        {
            return $"{request.Method} {request.Uri}";
        }

        public static string FormatResponse(Response response)
        {
            return response.ToString();
        }
    }
}
