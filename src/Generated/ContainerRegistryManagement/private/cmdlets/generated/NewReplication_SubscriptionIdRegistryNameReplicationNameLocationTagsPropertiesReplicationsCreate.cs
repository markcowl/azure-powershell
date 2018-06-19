namespace Sample.API.Cmdlets
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"Replication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate")]
    [System.Management.Automation.OutputType(typeof(Sample.API.Models.IReplication))]
    public class NewReplication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate : System.Management.Automation.PSCmdlet, Microsoft.Rest.ClientRuntime.IEventListener
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
        /// <summary>Backing field for Replication property</summary>
        private Sample.API.Models.IReplication _replication;

        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "An object that represents a replication for a container registry.")]
        public Sample.API.Models.IReplication Replication
        {
            get
            {
                return this._replication;
            }
            set
            {
                this._replication = value;
            }
        }
        /// <summary>Backing field for ReplicationName property</summary>
        private string _replicationName;

        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the replication.")]
        public string ReplicationName
        {
            get
            {
                return this._replicationName;
            }
            set
            {
                this._replicationName = value;
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
        protected override void BeginProcessing()
        {
            _resourceGroupName = Sample.API.Module.Instance.GetParameterValue(Sample.API.Module.Instance.Name, this.MyInvocation.BoundParameters, "resourceGroupName") as string;
        }
        public Sample.API.Cmdlets.NewReplication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate Clone()
        {
            var clone = FromJson(this.ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll));
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            return clone;
        }
        /// <param name="node"> </param>
        public static Sample.API.Cmdlets.NewReplication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new NewReplication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate(json) : null;
        }
        /// <param name="jsonText"> </param>
        public static Sample.API.Cmdlets.NewReplication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate FromJsonString(string jsonText) => string.IsNullOrEmpty(jsonText) ? null : FromJson(Carbon.Json.JsonObject.Parse(jsonText));
        public NewReplication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate()
        {
        }
        /// <param name="json"> </param>
        internal NewReplication_SubscriptionIdRegistryNameReplicationNameLocationTagsPropertiesReplicationsCreate(Carbon.Json.JsonObject json)
        {
            // deserialize the contents
            json.StringProperty("ResourceGroupName", ref _resourceGroupName);
            json.StringProperty("SubscriptionId", ref _subscriptionId);
            json.StringProperty("RegistryName", ref _registryName);
            json.StringProperty("ReplicationName", ref _replicationName);
            _replication = Sample.API.Models.Replication.FromJson(json.Property("Replication"));
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
            await this.Client.ReplicationsCreate(ApiVersion, SubscriptionId, ResourceGroupName, RegistryName, ReplicationName, Replication, async(response) => {
                // on200 - response for 200 / application/json
                // (await response.Result) // should be Sample.API.Models.IReplication
                WriteObject(await response.Result);
            }, async(response) => {
                // on201 - response for 201 / application/json
                // (await response.Result) // should be Sample.API.Models.IReplication
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
        /// <param name="container"> </param>
        /// <param name="serializationMode"> </param>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.JsonMode serializationMode)
        {
            // serialization method
            var result = container ?? new Carbon.Json.JsonObject();
            container.SafeAdd( "ResourceGroupName", Carbon.Json.JsonString.Create(ResourceGroupName));
            container.SafeAdd( "SubscriptionId", Carbon.Json.JsonString.Create(SubscriptionId));
            container.SafeAdd( "RegistryName", Carbon.Json.JsonString.Create(RegistryName));
            container.SafeAdd( "ReplicationName", Carbon.Json.JsonString.Create(ReplicationName));
            container.SafeAdd( "Replication", Replication?.ToJson());
            return result;
        }
    }
}