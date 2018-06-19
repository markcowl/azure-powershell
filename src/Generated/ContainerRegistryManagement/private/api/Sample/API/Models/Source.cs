namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class Source : Sample.API.Models.ISource
    {
        /// <summary>Backing field for Addr property</summary>
        private string _addr;

        /// <summary>
        /// The IP or hostname and the port of the registry node that generated the event. Generally, this will be resolved by os.Hostname()
        /// along with the running port.
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
        /// <summary>Backing field for InstanceID property</summary>
        private string _instanceID;

        /// <summary>The running instance of an application. Changes after each restart.</summary>
        public string InstanceID
        {
            get
            {
                return this._instanceID;
            }
            set
            {
                this._instanceID = value;
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
        public static Sample.API.Models.ISource FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Source(json) : null;
        }
        /// <param name="json"> </param>
        internal Source(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("addr", ref this._addr);
            json.StringProperty("instanceID", ref this._instanceID);
            AfterFromJson(json);
        }
        public Source()
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
            result.SafeAdd( "addr", Carbon.Json.JsonString.Create(Addr));
            result.SafeAdd( "instanceID", Carbon.Json.JsonString.Create(InstanceID));
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface ISource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Addr { get; set; }
        string InstanceID { get; set; }
    }
}