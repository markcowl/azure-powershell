namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class EventRequestMessage : Sample.API.Models.IEventRequestMessage, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Content property</summary>
        private Sample.API.Models.IEventContent _content;

        /// <summary>The content of the event request message.</summary>
        public Sample.API.Models.IEventContent Content
        {
            get
            {
                return this._content;
            }
            set
            {
                this._content = value;
            }
        }
        /// <summary>Backing field for Headers property</summary>
        private System.Collections.Generic.Dictionary<string,string> _headers;

        /// <summary>The headers of the event request message.</summary>
        public System.Collections.Generic.Dictionary<string,string> Headers
        {
            get
            {
                return this._headers;
            }
            set
            {
                this._headers = value;
            }
        }
        /// <summary>Backing field for Method property</summary>
        private string _method;

        /// <summary>The HTTP method used to send the event request message.</summary>
        public string Method
        {
            get
            {
                return this._method;
            }
            set
            {
                this._method = value;
            }
        }
        /// <summary>Backing field for RequestUri property</summary>
        private string _requestUri;

        /// <summary>The URI used to send the event request message.</summary>
        public string RequestUri
        {
            get
            {
                return this._requestUri;
            }
            set
            {
                this._requestUri = value;
            }
        }
        /// <summary>Backing field for Version property</summary>
        private string _version;

        /// <summary>The HTTP message version.</summary>
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
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
        internal EventRequestMessage(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("method", ref this._method);
            json.SafeAdd( "content", this._content?.ToJson());
            json.DictionaryProperty("headers", ref this._headers, __each => __each is Carbon.Json.JsonString s ? s : null );
            json.StringProperty("requestUri", ref this._requestUri);
            json.StringProperty("version", ref this._version);
            AfterFromJson(json);
        }
        public EventRequestMessage()
        {
        }
        /// <param name="node"> </param>
        public static Sample.API.Models.IEventRequestMessage FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new EventRequestMessage(json) : null;
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
            result.SafeAdd( "method", Carbon.Json.JsonString.Create(Method));
            result.SafeAdd( "content", Content?.ToJson());
            result.SafeAdd( "headers", Carbon.Json.JsonObject.Create( Headers, __each=> Carbon.Json.JsonString.Create(__each)));
            result.SafeAdd( "requestUri", Carbon.Json.JsonString.Create(RequestUri));
            result.SafeAdd( "version", Carbon.Json.JsonString.Create(Version));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertObjectIsValid(nameof(Content), Content);
        }
    }
    public partial interface IEventRequestMessage : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IEventContent Content { get; set; }
        System.Collections.Generic.Dictionary<string,string> Headers { get; set; }
        string Method { get; set; }
        string RequestUri { get; set; }
        string Version { get; set; }
    }
}