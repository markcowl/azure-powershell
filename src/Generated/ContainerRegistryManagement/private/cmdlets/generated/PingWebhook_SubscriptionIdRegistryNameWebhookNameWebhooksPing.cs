namespace Sample.API.Cmdlets
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsDiagnostic.Ping, @"Webhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing")]
    [System.Management.Automation.OutputType(typeof(string))]
    public class PingWebhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing : System.Management.Automation.PSCmdlet, Microsoft.Rest.ClientRuntime.IEventListener
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
        /// <summary>Backing field for RegistryName property</summary>
        private string _registryName;

        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the container registry.")]
        public string RegistryName
        {
            get
            {
                return this._registryName;
            }
            set
            {
                this._registryName = value;
            }
        }
        /// <summary>Backing field for ResourceGroupName property</summary>
        private string _resourceGroupName;

        public string ResourceGroupName
        {
            get
            {
                return this._resourceGroupName;
            }
            set
            {
                this._resourceGroupName = value;
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
        /// <summary>Backing field for WebhookName property</summary>
        private string _webhookName;

        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the webhook.")]
        public string WebhookName
        {
            get
            {
                return this._webhookName;
            }
            set
            {
                this._webhookName = value;
            }
        }
        protected override void BeginProcessing()
        {
            _resourceGroupName = Sample.API.Module.Instance.GetParameterValue(Sample.API.Module.Instance.Name, this.MyInvocation.BoundParameters, "resourceGroupName") as string;
        }
        public Sample.API.Cmdlets.PingWebhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing Clone()
        {
            var clone = FromJson(this.ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll));
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            return clone;
        }
        /// <param name="node"> </param>
        public static Sample.API.Cmdlets.PingWebhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new PingWebhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing(json) : null;
        }
        /// <param name="jsonText"> </param>
        public static Sample.API.Cmdlets.PingWebhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing FromJsonString(string jsonText) => string.IsNullOrEmpty(jsonText) ? null : FromJson(Carbon.Json.JsonObject.Parse(jsonText));
        public PingWebhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing()
        {
        }
        /// <param name="json"> </param>
        internal PingWebhook_SubscriptionIdRegistryNameWebhookNameWebhooksPing(Carbon.Json.JsonObject json)
        {
            // deserialize the contents
            json.StringProperty("ResourceGroupName", ref _resourceGroupName);
            json.StringProperty("SubscriptionId", ref _subscriptionId);
            json.StringProperty("RegistryName", ref _registryName);
            json.StringProperty("WebhookName", ref _webhookName);
        }
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
            await this.Client.WebhooksPing(ApiVersion, SubscriptionId, ResourceGroupName, RegistryName, WebhookName, async(response) => {
                // on200 - response for 200 / application/json
                // (await response.Result) // should be Sample.API.Models.IEventInfo
                WriteObject((await response.Result).Id);
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
        /// <param name="container"> </param>
        /// <param name="serializationMode"> </param>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.JsonMode serializationMode)
        {
            // serialization method
            var result = container ?? new Carbon.Json.JsonObject();
            container.SafeAdd( "ResourceGroupName", Carbon.Json.JsonString.Create(ResourceGroupName));
            container.SafeAdd( "SubscriptionId", Carbon.Json.JsonString.Create(SubscriptionId));
            container.SafeAdd( "RegistryName", Carbon.Json.JsonString.Create(RegistryName));
            container.SafeAdd( "WebhookName", Carbon.Json.JsonString.Create(WebhookName));
            return result;
        }
    }
}