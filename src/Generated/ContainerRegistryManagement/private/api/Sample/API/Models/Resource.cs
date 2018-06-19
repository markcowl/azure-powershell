namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class Resource : Sample.API.Models.IResource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Id property</summary>
        private string _id;

        /// <summary>The resource ID.</summary>
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
        /// <summary>Backing field for Location property</summary>
        private string _location;

        /// <summary>
        /// The location of the resource. This cannot be changed after the resource is created.
        /// </summary>
        public string Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>The name of the resource.</summary>
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
        /// <summary>Backing field for Tags property</summary>
        private System.Collections.Generic.Dictionary<string,string> _tags;

        /// <summary>The tags of the resource.</summary>
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
        /// <summary>Backing field for Type property</summary>
        private string _type;

        /// <summary>The type of the resource.</summary>
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
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
        public static Sample.API.Models.IResource FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Resource(json) : null;
        }
        /// <param name="json"> </param>
        internal Resource(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("name", ref this._name);
            json.StringProperty("type", ref this._type);
            json.StringProperty("id", ref this._id);
            json.StringProperty("location", ref this._location);
            json.DictionaryProperty("tags", ref this._tags, __each => __each is Carbon.Json.JsonString s ? s : null );
            AfterFromJson(json);
        }
        public Resource()
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
                result.SafeAdd( "name", Carbon.Json.JsonString.Create(Name));
            }
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "type", Carbon.Json.JsonString.Create(Type));
            }
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "id", Carbon.Json.JsonString.Create(Id));
            }
            result.SafeAdd( "location", Carbon.Json.JsonString.Create(Location));
            result.SafeAdd( "tags", Carbon.Json.JsonObject.Create( Tags, __each=> Carbon.Json.JsonString.Create(__each)));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(Location),Location);
        }
    }
    public partial interface IResource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Id { get; set; }
        string Location { get; set; }
        string Name { get; set; }
        System.Collections.Generic.Dictionary<string,string> Tags { get; set; }
        string Type { get; set; }
    }
}