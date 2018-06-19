namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class RegistryUsage : Sample.API.Models.IRegistryUsage
    {
        /// <summary>Backing field for CurrentValue property</summary>
        private long? _currentValue;

        /// <summary>The current value of the usage.</summary>
        public long? CurrentValue
        {
            get
            {
                return this._currentValue;
            }
            set
            {
                this._currentValue = value;
            }
        }
        /// <summary>Backing field for Limit property</summary>
        private long? _limit;

        /// <summary>The limit of the usage.</summary>
        public long? Limit
        {
            get
            {
                return this._limit;
            }
            set
            {
                this._limit = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>The name of the usage.</summary>
        public string Name
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
        /// <summary>Backing field for Unit property</summary>
        private Sample.API.Support.RegistryUsageUnit _unit;

        /// <summary>The unit of measurement.</summary>
        public Sample.API.Support.RegistryUsageUnit Unit
        {
            get
            {
                return this._unit;
            }
            set
            {
                this._unit = value;
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
        public static Sample.API.Models.IRegistryUsage FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new RegistryUsage(json) : null;
        }
        /// <param name="json"> </param>
        internal RegistryUsage(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("name", ref this._name);
            json.NumberProperty("currentValue", ref this._currentValue);
            json.NumberProperty("limit", ref this._limit);
            json.SafeAdd( "unit", Carbon.Json.JsonString.Create(this._unit));
            AfterFromJson(json);
        }
        public RegistryUsage()
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
            result.SafeAdd( "currentValue", Carbon.Json.JsonNumber.Create(CurrentValue));
            result.SafeAdd( "limit", Carbon.Json.JsonNumber.Create(Limit));
            result.SafeAdd( "unit", Carbon.Json.JsonString.Create(Unit));
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface IRegistryUsage : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        long? CurrentValue { get; set; }
        long? Limit { get; set; }
        string Name { get; set; }
        Sample.API.Support.RegistryUsageUnit Unit { get; set; }
    }
}