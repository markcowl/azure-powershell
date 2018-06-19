namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class ReplicationUpdateParameters : Sample.API.Models.IReplicationUpdateParameters
    {
        /// <summary>Backing field for Tags property</summary>
        private System.Collections.Generic.Dictionary<string,string> _tags;

        /// <summary>The tags for the replication.</summary>
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
        public static Sample.API.Models.IReplicationUpdateParameters FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ReplicationUpdateParameters(json) : null;
        }
        /// <param name="json"> </param>
        internal ReplicationUpdateParameters(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.DictionaryProperty("tags", ref this._tags, __each => __each is Carbon.Json.JsonString s ? s : null );
            AfterFromJson(json);
        }
        public ReplicationUpdateParameters()
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
            result.SafeAdd( "tags", Carbon.Json.JsonObject.Create( Tags, __each=> Carbon.Json.JsonString.Create(__each)));
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface IReplicationUpdateParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        System.Collections.Generic.Dictionary<string,string> Tags { get; set; }
    }
}