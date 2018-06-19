namespace Sample.API.Cmdlets
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsDiagnostic.Test, @"RegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IRegistryNameStatus))]
    public class TestRegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability : System.Management.Automation.PSCmdlet, Microsoft.Rest.ClientRuntime.IEventListener
    {
        private System.Threading.CancellationTokenSource _cancellationTokenSource = new System.Threading.CancellationTokenSource();
        public string ApiVersion => @"2017-10-01";
        public System.Action Cancel => _cancellationTokenSource.Cancel;
        public Sample.API.ContainerRegistryManagementClient Client => Sample.API.Module.Instance.ClientAPI;
        [System.Management.Automation.Parameter(Mandatory = false, DontShow= true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        public Microsoft.Rest.ClientRuntime.SendAsyncStep[] HttpPipelineAppend {get;set;}
        [System.Management.Automation.Parameter(Mandatory = false, DontShow= true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        public Microsoft.Rest.ClientRuntime.SendAsyncStep[] HttpPipelinePrepend {get;set;}
        /// <summary>Backing field for RegistryNameCheckRequest property</summary>
        private Sample.API.Models.IRegistryNameCheckRequest _registryNameCheckRequest;

        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "A request to check whether a container registry name is available.")]
        public Sample.API.Models.IRegistryNameCheckRequest RegistryNameCheckRequest
        {
            get
            {
                return this._registryNameCheckRequest;
            }
            set
            {
                this._registryNameCheckRequest = value;
            }
        }
        /// <summary>Backing field for SubscriptionId property</summary>
        private string _subscriptionId;

        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The Microsoft Azure subscription ID.")]
        public string SubscriptionId
        {
            get
            {
                return this._subscriptionId;
            }
            set
            {
                this._subscriptionId = value;
            }
        }
        public System.Threading.CancellationToken Token => _cancellationTokenSource.Token;
        protected override void BeginProcessing()
        {
        }
        public Sample.API.Cmdlets.TestRegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability Clone()
        {
            var clone = FromJson(this.ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll));
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            return clone;
        }
        /// <param name="node"> </param>
        public static Sample.API.Cmdlets.TestRegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new TestRegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability(json) : null;
        }
        /// <param name="jsonText"> </param>
        public static Sample.API.Cmdlets.TestRegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability FromJsonString(string jsonText) => string.IsNullOrEmpty(jsonText) ? null : FromJson(Carbon.Json.JsonObject.Parse(jsonText));
        protected override void ProcessRecord()
        {
            this.Signal(Microsoft.Rest.ClientRuntime.Events.CmdletProcessRecordStart).Wait(); if( this.Token.IsCancellationRequested ) { return; }
            try
            {
                // work
                using( var asyncCommandRuntime = new Microsoft.Rest.ClientRuntime.PowerShell.AsyncCommandRuntime(this, Token) )
                {
                    asyncCommandRuntime.Wait( ProcessRecordAsync(),Token);
                }
            }
            catch(System.Exception exception)
            {
                this.Signal(Microsoft.Rest.ClientRuntime.Events.CmdletException).Wait(); if( this.Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.CloseError, null) );
            }
        }
        protected async System.Threading.Tasks.Task ProcessRecordAsync()
        {
            await this.Signal(Microsoft.Rest.ClientRuntime.Events.CmdletGetPipeline); if( this.Token.IsCancellationRequested ) { return; }
            var pipeline = Sample.API.Module.Instance.CreatePipeline(this.MyInvocation.BoundParameters);
            pipeline.Prepend(HttpPipelinePrepend);
            pipeline.Append(HttpPipelineAppend);
            // get the client instance
            await this.Signal(Microsoft.Rest.ClientRuntime.Events.CmdletBeforeAPICall); if( this.Token.IsCancellationRequested ) { return; }
            await this.Client.RegistriesCheckNameAvailability(ApiVersion, SubscriptionId, RegistryNameCheckRequest, async(response) => {
                // on200 - response for 200 / application/json
                // (await response.Result) // should be Sample.API.Models.IRegistryNameStatus
                WriteObject(await response.Result);
            }, this, pipeline);
            await this.Signal(Microsoft.Rest.ClientRuntime.Events.CmdletAfterAPICall); if( this.Token.IsCancellationRequested ) { return; }
        }
        /// <param name="id"> </param>
        /// <param name="token"> </param>
        /// <param name="messageData"> </param>
        public async System.Threading.Tasks.Task Signal(string id, System.Threading.CancellationToken token, System.Func<Microsoft.Rest.ClientRuntime.EventData> messageData)
        {
            await Sample.API.Module.Instance.Signal(id, token, messageData);
            if(token.IsCancellationRequested)
            {
                return;
            }
            WriteDebug($"{id}, {messageData().Message ?? "<empty>"}");
        }
        public TestRegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability()
        {
        }
        /// <param name="json"> </param>
        internal TestRegistryNameAvailability_NameAvailabilitySubscriptionIdNameTypeRegistriesCheckNameAvailability(Carbon.Json.JsonObject json)
        {
            // deserialize the contents
            json.StringProperty("SubscriptionId", ref _subscriptionId);
            _registryNameCheckRequest = Sample.API.Models.RegistryNameCheckRequest.FromJson(json.Property("RegistryNameCheckRequest"));
        }
        /// <param name="container"> </param>
        /// <param name="serializationMode"> </param>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.JsonMode serializationMode)
        {
            // serialization method
            var result = container ?? new Carbon.Json.JsonObject();
            container.SafeAdd( "SubscriptionId", Carbon.Json.JsonString.Create(SubscriptionId));
            container.SafeAdd( "RegistryNameCheckRequest", RegistryNameCheckRequest?.ToJson());
            return result;
        }
    }
}