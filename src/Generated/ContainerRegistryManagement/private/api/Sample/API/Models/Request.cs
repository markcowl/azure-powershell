namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class Request : Sample.API.Models.IRequest
    {
        /// <summary>Backing field for Addr property</summary>
        private string _addr;

        /// <summary>
        /// The IP or hostname and possibly port of the client connection that initiated the event. This is the RemoteAddr from the
        /// standard http request.
        /// </summary>
        public string Addr
        {
            get
            {
                return this._addr;
            }
            set
            {
                this._addr = value;
            }
        }
        /// <summary>Backing field for Host property</summary>
        private string _host;

        /// <summary>
        /// The externally accessible hostname of the registry instance, as specified by the http host header on incoming requests.
        /// </summary>
        public string Host
        {
            get
            {
                return this._host;
            }
            set
            {
                this._host = value;
            }
        }
        /// <summary>Backing field for Id property</summary>
        private string _id;

        /// <summary>The ID of the request that initiated the event.</summary>
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
        /// <summary>Backing field for Method property</summary>
        private string _method;

        /// <summary>The request method that generated the event.</summary>
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
        /// <summary>Backing field for Useragent property</summary>
        private string _useragent;

        /// <summary>The user agent header of the request.</summary>
        public string Useragent
        {
            get
            {
                return this._useragent;
            }
            set
            {
                this._useragent = value;
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
        public static Sample.API.Models.IRequest FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Request(json) : null;
        }
        /// <param name="json"> </param>
        internal Request(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("method", ref this._method);
            json.StringProperty("addr", ref this._addr);
            json.StringProperty("host", ref this._host);
            json.StringProperty("id", ref this._id);
            json.StringProperty("useragent", ref this._useragent);
            AfterFromJson(json);
        }
        public Request()
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
            result.SafeAdd( "method", Carbon.Json.JsonString.Create(Method));
            result.SafeAdd( "addr", Carbon.Json.JsonString.Create(Addr));
            result.SafeAdd( "host", Carbon.Json.JsonString.Create(Host));
            result.SafeAdd( "id", Carbon.Json.JsonString.Create(Id));
            result.SafeAdd( "useragent", Carbon.Json.JsonString.Create(Useragent));
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface IRequest : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Addr { get; set; }
        string Host { get; set; }
        string Id { get; set; }
        string Method { get; set; }
        string Useragent { get; set; }
    }
}