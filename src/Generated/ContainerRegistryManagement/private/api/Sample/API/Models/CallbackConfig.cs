namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class CallbackConfig : Sample.API.Models.ICallbackConfig, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for CustomHeaders property</summary>
        private System.Collections.Generic.Dictionary<string,string> _customHeaders;

        /// <summary>Custom headers that will be added to the webhook notifications.</summary>
        public System.Collections.Generic.Dictionary<string,string> CustomHeaders
        {
            get
            {
                return this._customHeaders;
            }
            set
            {
                this._customHeaders = value;
            }
        }
        /// <summary>Backing field for ServiceUri property</summary>
        private string _serviceUri;

        /// <summary>The service URI for the webhook to post notifications.</summary>
        public string ServiceUri
        {
            get
            {
                return this._serviceUri;
            }
            set
            {
                this._serviceUri = value;
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
        internal CallbackConfig(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.DictionaryProperty("customHeaders", ref this._customHeaders, __each => __each is Carbon.Json.JsonString s ? s : null );
            json.StringProperty("serviceUri", ref this._serviceUri);
            AfterFromJson(json);
        }
        public CallbackConfig()
        {
        }
        /// <param name="node"> </param>
        public static Sample.API.Models.ICallbackConfig FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new CallbackConfig(json) : null;
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
            result.SafeAdd( "customHeaders", Carbon.Json.JsonObject.Create( CustomHeaders, __each=> Carbon.Json.JsonString.Create(__each)));
            result.SafeAdd( "serviceUri", Carbon.Json.JsonString.Create(ServiceUri));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(ServiceUri),ServiceUri);
        }
    }
    public partial interface ICallbackConfig : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.Collections.Generic.Dictionary<string,string> CustomHeaders { get; set; }
        string ServiceUri { get; set; }
    }
}