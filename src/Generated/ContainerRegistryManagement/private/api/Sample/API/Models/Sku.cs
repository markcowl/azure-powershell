namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class Sku : Sample.API.Models.ISku
    {
        /// <summary>Backing field for Name property</summary>
        private Sample.API.Support.SkuName _name;

        /// <summary>The SKU name of the container registry. Required for registry creation.</summary>
        public Sample.API.Support.SkuName Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for Tier property</summary>
        private Sample.API.Support.SkuTier _tier;

        /// <summary>The SKU tier based on the SKU name.</summary>
        public Sample.API.Support.SkuTier Tier
        {
            get
            {
                return this._tier;
            }
            set
            {
                this._tier = value;
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
        public static Sample.API.Models.ISku FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Sku(json) : null;
        }
        /// <param name="json"> </param>
        internal Sku(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.SafeAdd( "name", Carbon.Json.JsonString.Create(this._name));
            json.SafeAdd( "tier", Carbon.Json.JsonString.Create(this._tier));
            AfterFromJson(json);
        }
        public Sku()
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
            result.SafeAdd( "name", Carbon.Json.JsonString.Create(Name));
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "tier", Carbon.Json.JsonString.Create(Tier));
            }
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface ISku : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Support.SkuName Name { get; set; }
        Sample.API.Support.SkuTier Tier { get; set; }
    }
}