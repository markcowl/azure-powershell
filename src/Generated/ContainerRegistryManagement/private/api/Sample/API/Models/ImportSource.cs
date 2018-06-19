namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class ImportSource : Sample.API.Models.IImportSource, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for ResourceId property</summary>
        private string _resourceId;

        /// <summary>The resource identifier of the target Azure Container Registry.</summary>
        public string ResourceId
        {
            get
            {
                return this._resourceId;
            }
            set
            {
                this._resourceId = value;
            }
        }
        /// <summary>Backing field for SourceImage property</summary>
        private string _sourceImage;

        /// <summary>
        /// Repository name of the source image.
        /// Specify an image by repository ('hello-world'). This will use the 'latest' tag.
        /// Specify an image by tag ('hello-world:latest').
        /// Specify an image by sha256-based manifest digest ('hello-world@sha256:abc123').
        /// </summary>
        public string SourceImage
        {
            get
            {
                return this._sourceImage;
            }
            set
            {
                this._sourceImage = value;
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
        public static Sample.API.Models.IImportSource FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ImportSource(json) : null;
        }
        /// <param name="json"> </param>
        internal ImportSource(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("resourceId", ref this._resourceId);
            json.StringProperty("sourceImage", ref this._sourceImage);
            AfterFromJson(json);
        }
        public ImportSource()
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
            result.SafeAdd( "resourceId", Carbon.Json.JsonString.Create(ResourceId));
            result.SafeAdd( "sourceImage", Carbon.Json.JsonString.Create(SourceImage));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(ResourceId),ResourceId);
            await listener.AssertNotNull(nameof(SourceImage),SourceImage);
        }
    }
    public partial interface IImportSource : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string ResourceId { get; set; }
        string SourceImage { get; set; }
    }
}