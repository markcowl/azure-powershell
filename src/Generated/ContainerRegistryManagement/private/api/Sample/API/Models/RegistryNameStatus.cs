namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class RegistryNameStatus : Sample.API.Models.IRegistryNameStatus
    {
        /// <summary>Backing field for Message property</summary>
        private string _message;

        /// <summary>
        /// If any, the error message that provides more detail for the reason that the name is not available.
        /// </summary>
        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
            }
        }
        /// <summary>Backing field for NameAvailable property</summary>
        private bool? _nameAvailable;

        /// <summary>The value that indicates whether the name is available.</summary>
        public bool? NameAvailable
        {
            get
            {
                return this._nameAvailable;
            }
            set
            {
                this._nameAvailable = value;
            }
        }
        /// <summary>Backing field for Reason property</summary>
        private string _reason;

        /// <summary>If any, the reason that the name is not available.</summary>
        public string Reason
        {
            get
            {
                return this._reason;
            }
            set
            {
                this._reason = value;
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
        public static Sample.API.Models.IRegistryNameStatus FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new RegistryNameStatus(json) : null;
        }
        /// <param name="json"> </param>
        internal RegistryNameStatus(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("message", ref this._message);
            json.BooleanProperty("nameAvailable", ref this._nameAvailable);
            json.StringProperty("reason", ref this._reason);
            AfterFromJson(json);
        }
        public RegistryNameStatus()
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
            result.SafeAdd( "message", Carbon.Json.JsonString.Create(Message));
            result.SafeAdd( "nameAvailable", Carbon.Json.JsonBoolean.Create(NameAvailable));
            result.SafeAdd( "reason", Carbon.Json.JsonString.Create(Reason));
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface IRegistryNameStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Message { get; set; }
        bool? NameAvailable { get; set; }
        string Reason { get; set; }
    }
}