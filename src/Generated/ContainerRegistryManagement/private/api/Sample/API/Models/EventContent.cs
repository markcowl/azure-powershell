namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class EventContent : Sample.API.Models.IEventContent, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Action property</summary>
        private string _action;

        /// <summary>The action that encompasses the provided event.</summary>
        public string Action
        {
            get
            {
                return this._action;
            }
            set
            {
                this._action = value;
            }
        }
        /// <summary>Backing field for Actor property</summary>
        private Sample.API.Models.IActor _actor;

        /// <summary>
        /// The agent that initiated the event. For most situations, this could be from the authorization context of the request.
        /// </summary>
        public Sample.API.Models.IActor Actor
        {
            get
            {
                return this._actor;
            }
            set
            {
                this._actor = value;
            }
        }
        /// <summary>Backing field for Id property</summary>
        private string _id;

        /// <summary>The event ID.</summary>
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <summary>Backing field for Request property</summary>
        private Sample.API.Models.IRequest _request;

        /// <summary>The request that generated the event.</summary>
        public Sample.API.Models.IRequest Request
        {
            get
            {
                return this._request;
            }
            set
            {
                this._request = value;
            }
        }
        /// <summary>Backing field for Source property</summary>
        private Sample.API.Models.ISource _source;

        /// <summary>
        /// The registry node that generated the event. Put differently, while the actor initiates the event, the source generates
        /// it.
        /// </summary>
        public Sample.API.Models.ISource Source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }
        /// <summary>Backing field for Target property</summary>
        private Sample.API.Models.ITarget _target;

        /// <summary>The target of the event.</summary>
        public Sample.API.Models.ITarget Target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
        /// <summary>Backing field for Timestamp property</summary>
        private System.DateTime? _timestamp;

        /// <summary>The time at which the event occurred.</summary>
        public System.DateTime? Timestamp
        {
            get
            {
                return this._timestamp;
            }
            set
            {
                this._timestamp = value;
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
        /// <param name="json"> </param>
        internal EventContent(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("action", ref this._action);
            json.SafeAdd( "actor", this._actor?.ToJson());
            json.StringProperty("id", ref this._id);
            json.SafeAdd( "request", this._request?.ToJson());
            json.SafeAdd( "source", this._source?.ToJson());
            json.SafeAdd( "target", this._target?.ToJson());
            json.StringProperty("timestamp", ref this._timestamp);
            AfterFromJson(json);
        }
        public EventContent()
        {
        }
        /// <param name="node"> </param>
        public static Sample.API.Models.IEventContent FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new EventContent(json) : null;
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
            result.SafeAdd( "action", Carbon.Json.JsonString.Create(Action));
            result.SafeAdd( "actor", Actor?.ToJson());
            result.SafeAdd( "id", Carbon.Json.JsonString.Create(Id));
            result.SafeAdd( "request", Request?.ToJson());
            result.SafeAdd( "source", Source?.ToJson());
            result.SafeAdd( "target", Target?.ToJson());
            result.SafeAdd( "timestamp", Carbon.Json.JsonString.CreateDateTime(Timestamp));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertObjectIsValid(nameof(Actor), Actor);
            await listener.AssertObjectIsValid(nameof(Request), Request);
            await listener.AssertObjectIsValid(nameof(Source), Source);
            await listener.AssertObjectIsValid(nameof(Target), Target);
        }
    }
    public partial interface IEventContent : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Action { get; set; }
        Sample.API.Models.IActor Actor { get; set; }
        string Id { get; set; }
        Sample.API.Models.IRequest Request { get; set; }
        Sample.API.Models.ISource Source { get; set; }
        Sample.API.Models.ITarget Target { get; set; }
        System.DateTime? Timestamp { get; set; }
    }
}