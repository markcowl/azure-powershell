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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Net.Http;
using System.Collections.Generic;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Commands.Profile.Models;
using System.Globalization;
using Microsoft.Azure.Commands.Common.Authentication;
using System.IO;

namespace Microsoft.Azure.Commands.Common
{

    using GetEventData = Func<EventArgs>;
    using NextDelegate = Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Task<HttpResponseMessage>>;
    using SignalDelegate = Func<string, CancellationToken, Func<EventArgs>, Task>;
    using GetParameterDelegate = Func<string, Dictionary<string, object>, string, object>;
    using SendAsyncStepDelegate = Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Task<HttpResponseMessage>>, Task<HttpResponseMessage>>;
    using PipelineChangeDelegate = Action<Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Task<HttpResponseMessage>>, Task<HttpResponseMessage>>>;
    using ModuleLoadPipelineDelegate = Action<string, Action<Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Task<HttpResponseMessage>>, Task<HttpResponseMessage>>>, Action<Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Task<HttpResponseMessage>>, Task<HttpResponseMessage>>>>;
    using NewRequestPipelineDelegate = Action<Dictionary<string, object>, Action<Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Task<HttpResponseMessage>>, Task<HttpResponseMessage>>>, Action<Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Func<HttpRequestMessage, CancellationToken, Action, Func<string, CancellationToken, Func<EventArgs>, Task>, Task<HttpResponseMessage>>, Task<HttpResponseMessage>>>>;


    /// <summary>
    /// The Virtual Call table of the functions to be exported to the generated module
    /// </summary>
    public class VTable
    {
        public GetParameterDelegate GetParameterValue;
        public SignalDelegate EventListener;

        public ModuleLoadPipelineDelegate OnModuleLoad;
        public NewRequestPipelineDelegate OnNewRequest;
    }


    /// <summary>
    /// no-op send async impl that just writes to the console.
    /// </summary>
    public class NoOpSendAsync
    {
        private static NoOpSendAsync _instance;
        public static NoOpSendAsync Instance => NoOpSendAsync._instance ?? (NoOpSendAsync._instance = new NoOpSendAsync());

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">This is the HTTP Request</param>
        /// <param name="token">This is the CancellationToken -- check this to see if the call has been cancelled.</param>
        /// <param name="cancel">A Cancel() function that you can cancel the request</param>
        /// <param name="signal">You can signal events with this</param>
        /// <param name="next">Call this to continue the call</param>
        /// <returns></returns>
        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token, Action cancel, SignalDelegate signal, NextDelegate next)
        {

            Console.WriteLine($"Calling {request.RequestUri.AbsoluteUri}");

            // continue with pipeline.
            return next(request, token, cancel, signal);
        }
    }

    public class DumpResponse
    {
        private static DumpResponse _instance;
        public static DumpResponse Instance => DumpResponse._instance ?? (DumpResponse._instance = new DumpResponse());

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token, Action cancel, SignalDelegate signal, NextDelegate next)
        {
            var response = await next(request, token, cancel, signal);

            // continue with pipeline.

            foreach (var header in response.Headers)
            {
                Console.WriteLine($"output header : {header.Key} ==> {header.Value.Aggregate((c, e) => $"{c}{e}")}");
            }

            return response;
        }
    }

    public class UniqueId
    {
        private static UniqueId _instance;
        public static UniqueId Instance => UniqueId._instance ?? (UniqueId._instance = new UniqueId());

        private int count;

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token, Action cancel, SignalDelegate signal, NextDelegate next)
        {
            // add a header...
            request.Headers.Add("x-ms-unique-id", Interlocked.Increment(ref this.count).ToString());

            // continue with pipeline.
            return next(request, token, cancel, signal);
        }
    }

    public class DumpHeaders
    {
        private static DumpHeaders _instance;
        public static DumpHeaders Instance => DumpHeaders._instance ?? (DumpHeaders._instance = new DumpHeaders());

        public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken token, Action cancel, SignalDelegate signal, NextDelegate next)
        {
            // add a header...
            foreach (var header in request.Headers)
            {
                Console.WriteLine($"{header.Key} ==> {header.Value.Aggregate((c, e) => $"{c}{e}")}");
            }

            // continue with pipeline.
            return next(request, token, cancel, signal);
        }
    }

    internal class AuthorizeRequest
    {
        internal static Func<HttpRequestMessage, CancellationToken, Action, SignalDelegate, NextDelegate, Task<HttpResponseMessage>> SendHandler(IAzureContext context, IAuthenticationFactory factory, string resourceId)
        {
            return (request, cancelToken, cancelAction, signal, next) =>
            {
                var authToken = factory.Authenticate(context.Account, context.Environment, context.Tenant.Id, null, "Never", null, resourceId);
                authToken.AuthorizeRequest((type, token) => request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(type, token));
                return next(request, cancelToken, cancelAction, signal);
            };
        }
    }

    /// <summary>
    /// Cheap and dirty implementation of module functions (does not have to look like this!)
    /// </summary>
    public class Module
    {
        private static Module _instance;
        public static Module Instance => Module._instance ?? (Module._instance = new Module());

        public void OnModuleLoad(string moduleName, PipelineChangeDelegate prependStep, PipelineChangeDelegate appendStep)
        {
            Console.WriteLine("Called OnModuleLoad");
            // this will be called once when the module starts up 
            // the common module can prepend or append steps to the pipeline at this point.
            prependStep(UniqueId.Instance.SendAsync);

            // appendStep( RetryHandler.SendAsync );
        }

        public void OnNewRequest(Dictionary<string, object> boundParameters, PipelineChangeDelegate prependStep, PipelineChangeDelegate appendStep)
        {
            Console.WriteLine("Called OnNewRequest");

            // This is called at the beginning of ProcessRecordAsync.
            // You get the boundParameters, and can identify what you should be adding for auth header based on that.

            appendStep(DumpHeaders.Instance.SendAsync);
            appendStep(DumpResponse.Instance.SendAsync);

            IAzureContextContainer context;
            var contextConverter = new AzureContextConverter();
            if (boundParameters.ContainsKey("DefaultContext")
                && contextConverter.CanConvertFrom(boundParameters["DefaultContext"], typeof(IAzureContextContainer)))
            {
                context = contextConverter.ConvertFrom(boundParameters["DefaultContext"], typeof(IAzureContextContainer), CultureInfo.InvariantCulture, true) as IAzureContextContainer;
            }
            else
            {
                context = AzureRmProfileProvider.Instance.Profile;
            }

            appendStep(AuthorizeRequest.SendHandler(context.DefaultContext, AzureSession.Instance.AuthenticationFactory, AzureEnvironment.Endpoint.ResourceManager));

            // add a step that requires us to look into the boundParameters
            prependStep((request, token, cancel, signal, next) =>
            {
                // silly example (note: this would be playing with the bound parameters a bit later (during the API call, instead of at the pipeline setup point))

                // we can't cancel here.
                // and we can't check for cancellation?


                request.Headers.Add("x-ms-ps-number-bound-parameters", boundParameters.Count.ToString());

                // send an event
                signal("Tracing", token, () =>
                {
                    return new EventData
                    {
                        Message = "This is my sample message SampleMessage",
                    };
                });
                return next(request, token, cancel, signal);
            });
            // this will be called every time the client is about to make a request across the wire.

            // the common module can prepend or append steps to the pipeline at this point.
            // prependStep( AuthHeader.SendAsync );
            // prependStep( UniqueId.Instance.SendAsync );

        }

        public object GetParameterValue(string moduleName, Dictionary<string, object> boundParameters, string name)
        {
            switch (name)
            {
                case "subscriptionId":
                    return "subscription-id-123";

                case "resourceGroupName":
                    return "resource-group-name-foo";

                case "host":
                    return "management.azure.com";

                case "port":
                    return 443;
            }
            return null; // no value? 
        }

        public async Task EventListener(string id, CancellationToken token, GetEventData getEventData)
        {
            switch (id)
            {
                case Events.RequestCreated:
                    {
                        // once we're sure we're handling the event, then we can retrieve the event data. 
                        // (this ensures that we're not doing any of the work unless we really care about the event. )
                        var data = EventDataConverter.ConvertFrom(getEventData()); // also, we manually use our TypeConverter to return an appropriate type
                        Console.WriteLine($"REQUEST CREATED The contents are '{data.Id}' and '{data.Message}'");

                        if (data.RequestMessage is HttpRequestMessage msg)
                        {
                            // alias/casting the request message to an HttpRequestMessage is necessary so that we can 
                            // support other protocols later on. (ie, JSONRPC, MQTT, GRPC ,AMPQ, Etc..)

                            // at this point, we can do with the request  
                            msg.Headers.Add("x-ms-peekaboo", "true");
                            await msg.Content.CopyToAsync(new MemoryStream());
                        }
                    }
                    break;

                case Events.ResponseCreated:
                    {
                        // once we're sure we're handling the event, then we can retrieve the event data. 
                        // (this ensures that we're not doing any of the work unless we really care about the event. )
                        var data = EventDataConverter.ConvertFrom(getEventData());
                        Console.WriteLine($"RESPONSE CREATED The contents are '{data.Id}' and '{data.Message}'");
                        var request = data.RequestMessage as HttpRequestMessage;
                        if (request != null)
                        {
                            foreach (var header in request.Headers)
                            {
                                Console.WriteLine($"{header.Key} = {header.Value}");
                            }
                        }
                    }
                    break;

                case "Tracing":
                    {

                        var data = EventDataConverter.ConvertFrom(getEventData());
                        // this was our own code above that sent this message.
                        Console.WriteLine($"TRACING EVENT; The contents are '{data.Id}' and '{data.Message}'");
                    }
                    break;

                default:
                    // events we aren't actively looking at...
                    Console.WriteLine($"Skipped Event Handling for {id}");

                    // you'll note that by not calling getEventData() 
                    break;
            }
        }
    }


    [Cmdlet(VerbsLifecycle.Register, @"AzureModule")]
    public class RegisterAzureModule : System.Management.Automation.PSCmdlet
    {

        protected override void ProcessRecord()
        {
            try
            {
                WriteObject(new VTable
                {
                    // this gets called when the generated cmdlet needs a value
                    GetParameterValue = Module.Instance.GetParameterValue,

                    // this gets called for every event that is signaled
                    EventListener = Module.Instance.EventListener,

                    // this gets called at module load time (allows you to change the http pipeline)
                    OnModuleLoad = Module.Instance.OnModuleLoad,

                    // this gets called before the generated cmdlet makes a call across the wire (allows you to change the HTTP pipeline)
                    OnNewRequest = Module.Instance.OnNewRequest
                });
            }
            catch (Exception exception)
            {
                // Write exception out to error channel.
                WriteError(new ErrorRecord(exception, string.Empty, ErrorCategory.CloseError, null));
            }
        }
    }

}