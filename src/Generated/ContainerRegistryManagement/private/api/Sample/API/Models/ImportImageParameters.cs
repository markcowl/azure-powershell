namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class ImportImageParameters : Sample.API.Models.IImportImageParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Mode property</summary>
        private Sample.API.Support.ImportMode _mode;

        /// <summary>
        /// When Force, any existing target tags will be overwritten. When NoForce, any existing target tags will fail the operation
        /// before any copying begins.
        /// </summary>
        public Sample.API.Support.ImportMode Mode
        {
            get
            {
                return this._mode;
            }
            set
            {
                this._mode = value;
            }
        }
        /// <summary>Backing field for Source property</summary>
        private Sample.API.Models.IImportSource _source;

        /// <summary>The source of the image.</summary>
        public Sample.API.Models.IImportSource Source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }
        /// <summary>Backing field for TargetTags property</summary>
        private string[] _targetTags;

        /// <summary>
        /// List of strings of the form repo[:tag]. When tag is omitted the source will be used (or 'latest' if source tag is also
        /// omitted).
        /// </summary>
        public string[] TargetTags
        {
            get
            {
                return this._targetTags;
            }
            set
            {
                this._targetTags = value;
            }
        }
        /// <summary>Backing field for UntaggedTargetRepositories property</summary>
        private string[] _untaggedTargetRepositories;

        /// <summary>
        /// List of strings of repository names to do a manifest only copy. No tag will be created.
        /// </summary>
        public string[] UntaggedTargetRepositories
        {
            get
            {
                return this._untaggedTargetRepositories;
            }
            set
            {
                this._untaggedTargetRepositories = value;
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
        public static Sample.API.Models.IImportImageParameters FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new ImportImageParameters(json) : null;
        }
        /// <param name="json"> </param>
        internal ImportImageParameters(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.SafeAdd( "mode", Carbon.Json.JsonString.Create(this._mode));
            json.SafeAdd( "source", this._source?.ToJson());
            json.ArrayProperty("targetTags", ref this._targetTags, __each => __each is Carbon.Json.JsonString s ? s : null );
            json.ArrayProperty("untaggedTargetRepositories", ref this._untaggedTargetRepositories, __each => __each is Carbon.Json.JsonString s ? s : null );
            AfterFromJson(json);
        }
        public ImportImageParameters()
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
            result.SafeAdd( "mode", Carbon.Json.JsonString.Create(Mode));
            result.SafeAdd( "source", Source?.ToJson());
            result.SafeAdd( "targetTags", Carbon.Json.XNodeArray.Create( TargetTags, __each=> Carbon.Json.JsonString.Create(__each)));
            result.SafeAdd( "untaggedTargetRepositories", Carbon.Json.XNodeArray.Create( UntaggedTargetRepositories, __each=> Carbon.Json.JsonString.Create(__each)));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(Source), Source);
            await listener.AssertObjectIsValid(nameof(Source), Source);
        }
    }
    public partial interface IImportImageParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Support.ImportMode Mode { get; set; }
        Sample.API.Models.IImportSource Source { get; set; }
        string[] TargetTags { get; set; }
        string[] UntaggedTargetRepositories { get; set; }
    }
}