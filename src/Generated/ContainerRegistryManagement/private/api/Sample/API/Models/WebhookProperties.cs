namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class WebhookProperties : Sample.API.Models.IWebhookProperties, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Actions property</summary>
        private Sample.API.Support.WebhookAction[] _actions;

        /// <summary>The list of actions that trigger the webhook to post notifications.</summary>
        public Sample.API.Support.WebhookAction[] Actions
        {
            get
            {
                return this._actions;
            }
            set
            {
                this._actions = value;
            }
        }
        /// <summary>Backing field for ProvisioningState property</summary>
        private Sample.API.Support.ProvisioningState _provisioningState;

        /// <summary>The provisioning state of the webhook at the time the operation was called.</summary>
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
        /// <summary>Backing field for Scope property</summary>
        private string _scope;

        /// <summary>
        /// The scope of repositories where the event can be triggered. For example, 'foo:*' means events for all tags under repository
        /// 'foo'. 'foo:bar' means events for 'foo:bar' only. 'foo' is equivalent to 'foo:latest'. Empty means all events.
        /// </summary>
        public string Scope
        {
            get
            {
                return this._scope;
            }
            set
            {
                this._scope = value;
            }
        }
        /// <summary>Backing field for Status property</summary>
        private Sample.API.Support.WebhookStatus _status;

        /// <summary>The status of the webhook at the time the operation was called.</summary>
        public Sample.API.Support.WebhookStatus Status
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
        public static Sample.API.Models.IWebhookProperties FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new WebhookProperties(json) : null;
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
            result.SafeAdd( "actions", Carbon.Json.XNodeArray.Create( Actions, __each=> Carbon.Json.JsonString.Create(__each)));
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "provisioningState", Carbon.Json.JsonString.Create(ProvisioningState));
            }
            result.SafeAdd( "scope", Carbon.Json.JsonString.Create(Scope));
            result.SafeAdd( "status", Carbon.Json.JsonString.Create(Status));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(Actions),Actions);
        }
        /// <param name="json"> </param>
        internal WebhookProperties(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.ArrayProperty("actions", ref this._actions, __each => __each is Carbon.Json.JsonString s ? s.Value : null );
            json.SafeAdd( "provisioningState", Carbon.Json.JsonString.Create(this._provisioningState));
            json.StringProperty("scope", ref this._scope);
            json.SafeAdd( "status", Carbon.Json.JsonString.Create(this._status));
            AfterFromJson(json);
        }
        public WebhookProperties()
        {
        }
    }
    public partial interface IWebhookProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Support.WebhookAction[] Actions { get; set; }
        Sample.API.Support.ProvisioningState ProvisioningState { get; set; }
        string Scope { get; set; }
        Sample.API.Support.WebhookStatus Status { get; set; }
    }
}