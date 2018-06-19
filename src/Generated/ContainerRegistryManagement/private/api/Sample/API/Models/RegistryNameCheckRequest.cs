namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class RegistryNameCheckRequest : Sample.API.Models.IRegistryNameCheckRequest, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>The name of the container registry.</summary>
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
        /// <summary>Backing field for Type property</summary>
        private Sample.API.Support.ContainerRegistryResourceType _type;

        /// <summary>
        /// The resource type of the container registry. This field must be set to 'Microsoft.ContainerRegistry/registries'.
        /// </summary>
        public Sample.API.Support.ContainerRegistryResourceType Type
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
        public static Sample.API.Models.IRegistryNameCheckRequest FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new RegistryNameCheckRequest(json) : null;
        }
        /// <param name="json"> </param>
        internal RegistryNameCheckRequest(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("name", ref this._name);
            json.SafeAdd( "type", Carbon.Json.JsonString.Create(this._type));
            AfterFromJson(json);
        }
        public RegistryNameCheckRequest()
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
            result.SafeAdd( "type", Carbon.Json.JsonString.Create(Type));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(Name),Name);
            await listener.AssertMinimumLength(nameof(Name),Name,5);
            await listener.AssertMaximumLength(nameof(Name),Name,5);
            await listener.AssertRegEx(nameof(Name),Name,@"^[a-zA-Z0-9]*$");
        }
    }
    public partial interface IRegistryNameCheckRequest : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Name { get; set; }
        Sample.API.Support.ContainerRegistryResourceType Type { get; set; }
    }
}