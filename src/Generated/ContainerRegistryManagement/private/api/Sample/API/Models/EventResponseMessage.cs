namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class EventResponseMessage : Sample.API.Models.IEventResponseMessage
    {
        /// <summary>Backing field for Content property</summary>
        private string _content;

        /// <summary>The content of the event response message.</summary>
        public string Content
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

        /// <summary>The headers of the event response message.</summary>
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
        /// <summary>Backing field for ReasonPhrase property</summary>
        private string _reasonPhrase;

        /// <summary>The reason phrase of the event response message.</summary>
        public string ReasonPhrase
        {
            get
            {
                return this._reasonPhrase;
            }
            set
            {
                this._reasonPhrase = value;
            }
        }
        /// <summary>Backing field for StatusCode property</summary>
        private string _statusCode;

        /// <summary>The status code of the event response message.</summary>
        public string StatusCode
        {
            get
            {
                return this._statusCode;
            }
            set
            {
                this._statusCode = value;
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
        internal EventResponseMessage(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("content", ref this._content);
            json.DictionaryProperty("headers", ref this._headers, __each => __each is Carbon.Json.JsonString s ? s : null );
            json.StringProperty("reasonPhrase", ref this._reasonPhrase);
            json.StringProperty("statusCode", ref this._statusCode);
            json.StringProperty("version", ref this._version);
            AfterFromJson(json);
        }
        public EventResponseMessage()
        {
        }
        /// <param name="node"> </param>
        public static Sample.API.Models.IEventResponseMessage FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new EventResponseMessage(json) : null;
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
            result.SafeAdd( "content", Carbon.Json.JsonString.Create(Content));
            result.SafeAdd( "headers", Carbon.Json.JsonObject.Create( Headers, __each=> Carbon.Json.JsonString.Create(__each)));
            result.SafeAdd( "reasonPhrase", Carbon.Json.JsonString.Create(ReasonPhrase));
            result.SafeAdd( "statusCode", Carbon.Json.JsonString.Create(StatusCode));
            result.SafeAdd( "version", Carbon.Json.JsonString.Create(Version));
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface IEventResponseMessage : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Content { get; set; }
        System.Collections.Generic.Dictionary<string,string> Headers { get; set; }
        string ReasonPhrase { get; set; }
        string StatusCode { get; set; }
        string Version { get; set; }
    }
}