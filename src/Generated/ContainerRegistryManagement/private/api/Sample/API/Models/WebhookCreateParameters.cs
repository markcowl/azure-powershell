namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class WebhookCreateParameters : Sample.API.Models.IWebhookCreateParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Location property</summary>
        private string _location;

        /// <summary>
        /// The location of the webhook. This cannot be changed after the resource is created.
        /// </summary>
        public string Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        /// <summary>Backing field for Properties property</summary>
        private Sample.API.Models.IWebhookPropertiesCreateParameters _properties;

        /// <summary>The properties that the webhook will be created with.</summary>
        public Sample.API.Models.IWebhookPropertiesCreateParameters Properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
        /// <summary>Backing field for Tags property</summary>
        private System.Collections.Generic.Dictionary<string,string> _tags;

        /// <summary>The tags for the webhook.</summary>
        public System.Collections.Generic.Dictionary<string,string> Tags
        {
            get
            {
                return this._tags;
            }
            set
            {
                this._tags = value;
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
        public static Sample.API.Models.IWebhookCreateParameters FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new WebhookCreateParameters(json) : null;
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
            result.SafeAdd( "location", Carbon.Json.JsonString.Create(Location));
            result.SafeAdd( "properties", Properties?.ToJson());
            result.SafeAdd( "tags", Carbon.Json.JsonObject.Create( Tags, __each=> Carbon.Json.JsonString.Create(__each)));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(Location),Location);
            await listener.AssertObjectIsValid(nameof(Properties), Properties);
        }
        /// <param name="json"> </param>
        internal WebhookCreateParameters(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("location", ref this._location);
            json.SafeAdd( "properties", this._properties?.ToJson());
            json.DictionaryProperty("tags", ref this._tags, __each => __each is Carbon.Json.JsonString s ? s : null );
            AfterFromJson(json);
        }
        public WebhookCreateParameters()
        {
        }
    }
    public partial interface IWebhookCreateParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Location { get; set; }
        Sample.API.Models.IWebhookPropertiesCreateParameters Properties { get; set; }
        System.Collections.Generic.Dictionary<string,string> Tags { get; set; }
    }
}