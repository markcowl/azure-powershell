namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class OperationDefinition : Sample.API.Models.IOperationDefinition, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Display property</summary>
        private Sample.API.Models.IOperationDisplayDefinition _display;

        /// <summary>The display information for the container registry operation.</summary>
        public Sample.API.Models.IOperationDisplayDefinition Display
        {
            get
            {
                return this._display;
            }
            set
            {
                this._display = value;
            }
        }
        /// <summary>Backing field for Name property</summary>
        private string _name;

        /// <summary>Operation name: {provider}/{resource}/{operation}.</summary>
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
        public static Sample.API.Models.IOperationDefinition FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new OperationDefinition(json) : null;
        }
        /// <param name="json"> </param>
        internal OperationDefinition(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("name", ref this._name);
            json.SafeAdd( "display", this._display?.ToJson());
            AfterFromJson(json);
        }
        public OperationDefinition()
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
            result.SafeAdd( "display", Display?.ToJson());
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertObjectIsValid(nameof(Display), Display);
        }
    }
    public partial interface IOperationDefinition : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IOperationDisplayDefinition Display { get; set; }
        string Name { get; set; }
    }
}