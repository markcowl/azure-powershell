namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class ReplicationProperties : Sample.API.Models.IReplicationProperties, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ProvisioningState property</summary>
        private Sample.API.Support.ProvisioningState _provisioningState;

        /// <summary>The provisioning state of the replication at the time the operation was called.</summary>
        public Sample.API.Support.ProvisioningState ProvisioningState
        {
            get
            {
                return this._provisioningState;
            }
            set
            {
                this._provisioningState = value;
            }
        }
        /// <summary>Backing field for Status property</summary>
        private Sample.API.Models.IStatus _status;

        /// <summary>The status of the replication at the time the operation was called.</summary>
        public Sample.API.Models.IStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <param name="json"> The JsonNode that should be deserialized into this object. </param>
        partial void AfterFromJson(Carbon.Json.JsonObject json);
        /// <param name="container"> The JSON container that the serialization result will be placed in. </param>
        partial void AfterToJson(ref Carbon.Json.JsonObject container);
        /// <param name="json"> The JsonNode that should be deserialized into this object. </param>
        /// <param name="returnNow"> Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly. </param>
        partial void BeforeFromJson(Carbon.Json.JsonObject json, ref bool returnNow);
        /// <param name="container"> The JSON container that the serialization result will be placed in. </param>
        /// <param name="returnNow"> Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly. </param>
        partial void BeforeToJson(ref Carbon.Json.JsonObject container, ref bool returnNow);
        /// <param name="node"> </param>
        public static Sample.API.Models.IReplicationProperties FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ReplicationProperties(json) : null;
        }
        /// <param name="json"> </param>
        internal ReplicationProperties(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.SafeAdd( "provisioningState", Carbon.Json.JsonString.Create(this._provisioningState));
            json.SafeAdd( "status", this._status?.ToJson());
            AfterFromJson(json);
        }
        public ReplicationProperties()
        {
        }
        /// <param name="container"> </param>
        /// <param name="serializationMode"> </param>
        public Carbon.Json.JsonNode ToJson(Carbon.Json.JsonObject container, Microsoft.Rest.ClientRuntime.JsonMode serializationMode)
        {
            var result = container ?? new Carbon.Json.JsonObject();
            bool returnNow = false;
            BeforeToJson(ref result, ref returnNow);
            if(returnNow)
            {
                return result;
            }
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "provisioningState", Carbon.Json.JsonString.Create(ProvisioningState));
            }
            result.SafeAdd( "status", Status?.ToJson());
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertObjectIsValid(nameof(Status), Status);
        }
    }
    public partial interface IReplicationProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Support.ProvisioningState ProvisioningState { get; set; }
        Sample.API.Models.IStatus Status { get; set; }
    }
}