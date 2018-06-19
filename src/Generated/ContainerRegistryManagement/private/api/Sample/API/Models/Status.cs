namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class Status : Sample.API.Models.IStatus
    {
        /// <summary>Backing field for DisplayStatus property</summary>
        private string _displayStatus;

        /// <summary>The short label for the status.</summary>
        public string DisplayStatus
        {
            get
            {
                return this._displayStatus;
            }
            set
            {
                this._displayStatus = value;
            }
        }
        /// <summary>Backing field for Message property</summary>
        private string _message;

        /// <summary>The detailed message for the status, including alerts and error messages.</summary>
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
        /// <summary>Backing field for Timestamp property</summary>
        private System.DateTime? _timestamp;

        /// <summary>The timestamp when the status was changed to the current value.</summary>
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
        /// <param name="node"> </param>
        public static Sample.API.Models.IStatus FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Status(json) : null;
        }
        /// <param name="json"> </param>
        internal Status(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("displayStatus", ref this._displayStatus);
            json.StringProperty("message", ref this._message);
            json.StringProperty("timestamp", ref this._timestamp);
            AfterFromJson(json);
        }
        public Status()
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
                result.SafeAdd( "displayStatus", Carbon.Json.JsonString.Create(DisplayStatus));
            }
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "message", Carbon.Json.JsonString.Create(Message));
            }
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "timestamp", Carbon.Json.JsonString.CreateDateTime(Timestamp));
            }
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface IStatus : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string DisplayStatus { get; set; }
        string Message { get; set; }
        System.DateTime? Timestamp { get; set; }
    }
}