namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class Replication : Sample.API.Models.IReplication, Microsoft.Rest.ClientRuntime.IValidates
    {
        private Sample.API.Models.IResource _resource = new Sample.API.Models.Resource();
        public string Id
        {
            get
            {
                return _resource.Id;
            }
            set
            {
                _resource.Id = value;
            }
        }
        public string Location
        {
            get
            {
                return _resource.Location;
            }
            set
            {
                _resource.Location = value;
            }
        }
        public string Name
        {
            get
            {
                return _resource.Name;
            }
            set
            {
                _resource.Name = value;
            }
        }
        /// <summary>Backing field for Properties property</summary>
        private Sample.API.Models.IReplicationProperties _properties;

        /// <summary>The properties of the replication.</summary>
        public Sample.API.Models.IReplicationProperties Properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
        public System.Collections.Generic.Dictionary<string,string> Tags
        {
            get
            {
                return _resource.Tags;
            }
            set
            {
                _resource.Tags = value;
            }
        }
        public string Type
        {
            get
            {
                return _resource.Type;
            }
            set
            {
                _resource.Type = value;
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
        public static Sample.API.Models.IReplication FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Replication(json) : null;
        }
        /// <param name="json"> </param>
        internal Replication(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            _resource = new Sample.API.Models.Resource(json);
            json.SafeAdd( "properties", this._properties?.ToJson());
            AfterFromJson(json);
        }
        public Replication()
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
            _resource?.ToJson(result, serializationMode);
            result.SafeAdd( "properties", Properties?.ToJson());
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(_resource), _resource);
            await listener.AssertObjectIsValid(nameof(_resource), _resource);
            await listener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    public partial interface IReplication : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.IResource {
        Sample.API.Models.IReplicationProperties Properties { get; set; }
    }
}