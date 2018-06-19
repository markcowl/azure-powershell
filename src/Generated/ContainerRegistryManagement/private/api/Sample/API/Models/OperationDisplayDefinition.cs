namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class OperationDisplayDefinition : Sample.API.Models.IOperationDisplayDefinition
    {
        /// <summary>Backing field for Description property</summary>
        private string _description;

        /// <summary>The description for the operation.</summary>
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for Operation property</summary>
        private string _operation;

        /// <summary>The operation that users can perform.</summary>
        public string Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
            }
        }
        /// <summary>Backing field for Provider property</summary>
        private string _provider;

        /// <summary>The resource provider name: Microsoft.ContainerRegistry.</summary>
        public string Provider
        {
            get
            {
                return this._provider;
            }
            set
            {
                this._provider = value;
            }
        }
        /// <summary>Backing field for Resource property</summary>
        private string _resource;

        /// <summary>The resource on which the operation is performed.</summary>
        public string Resource
        {
            get
            {
                return this._resource;
            }
            set
            {
                this._resource = value;
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
        public static Sample.API.Models.IOperationDisplayDefinition FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new OperationDisplayDefinition(json) : null;
        }
        /// <param name="json"> </param>
        internal OperationDisplayDefinition(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("description", ref this._description);
            json.StringProperty("operation", ref this._operation);
            json.StringProperty("provider", ref this._provider);
            json.StringProperty("resource", ref this._resource);
            AfterFromJson(json);
        }
        public OperationDisplayDefinition()
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
            result.SafeAdd( "description", Carbon.Json.JsonString.Create(Description));
            result.SafeAdd( "operation", Carbon.Json.JsonString.Create(Operation));
            result.SafeAdd( "provider", Carbon.Json.JsonString.Create(Provider));
            result.SafeAdd( "resource", Carbon.Json.JsonString.Create(Resource));
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface IOperationDisplayDefinition : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Description { get; set; }
        string Operation { get; set; }
        string Provider { get; set; }
        string Resource { get; set; }
    }
}