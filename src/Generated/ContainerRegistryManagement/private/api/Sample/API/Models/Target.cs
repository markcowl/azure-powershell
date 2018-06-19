namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class Target : Sample.API.Models.ITarget
    {
        /// <summary>Backing field for Digest property</summary>
        private string _digest;

        /// <summary>
        /// The digest of the content, as defined by the Registry V2 HTTP API Specification.
        /// </summary>
        public string Digest
        {
            get
            {
                return this._digest;
            }
            set
            {
                this._digest = value;
            }
        }
        /// <summary>Backing field for Length property</summary>
        private long? _length;

        /// <summary>The number of bytes of the content. Same as Size field.</summary>
        public long? Length
        {
            get
            {
                return this._length;
            }
            set
            {
                this._length = value;
            }
        }
        /// <summary>Backing field for MediaType property</summary>
        private string _mediaType;

        /// <summary>The MIME type of the referenced object.</summary>
        public string MediaType
        {
            get
            {
                return this._mediaType;
            }
            set
            {
                this._mediaType = value;
            }
        }
        /// <summary>Backing field for Repository property</summary>
        private string _repository;

        /// <summary>The repository name.</summary>
        public string Repository
        {
            get
            {
                return this._repository;
            }
            set
            {
                this._repository = value;
            }
        }
        /// <summary>Backing field for Size property</summary>
        private long? _size;

        /// <summary>The number of bytes of the content. Same as Length field.</summary>
        public long? Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        /// <summary>Backing field for Tag property</summary>
        private string _tag;

        /// <summary>The tag name.</summary>
        public string Tag
        {
            get
            {
                return this._tag;
            }
            set
            {
                this._tag = value;
            }
        }
        /// <summary>Backing field for Url property</summary>
        private string _url;

        /// <summary>The direct URL to the content.</summary>
        public string Url
        {
            get
            {
                return this._url;
            }
            set
            {
                this._url = value;
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
        public static Sample.API.Models.ITarget FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Target(json) : null;
        }
        /// <param name="json"> </param>
        internal Target(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("digest", ref this._digest);
            json.NumberProperty("length", ref this._length);
            json.StringProperty("mediaType", ref this._mediaType);
            json.StringProperty("repository", ref this._repository);
            json.NumberProperty("size", ref this._size);
            json.StringProperty("tag", ref this._tag);
            json.StringProperty("url", ref this._url);
            AfterFromJson(json);
        }
        public Target()
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
            result.SafeAdd( "digest", Carbon.Json.JsonString.Create(Digest));
            result.SafeAdd( "length", Carbon.Json.JsonNumber.Create(Length));
            result.SafeAdd( "mediaType", Carbon.Json.JsonString.Create(MediaType));
            result.SafeAdd( "repository", Carbon.Json.JsonString.Create(Repository));
            result.SafeAdd( "size", Carbon.Json.JsonNumber.Create(Size));
            result.SafeAdd( "tag", Carbon.Json.JsonString.Create(Tag));
            result.SafeAdd( "url", Carbon.Json.JsonString.Create(Url));
            AfterToJson(ref result);
            return result;
        }
    }
    public partial interface ITarget : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string Digest { get; set; }
        long? Length { get; set; }
        string MediaType { get; set; }
        string Repository { get; set; }
        long? Size { get; set; }
        string Tag { get; set; }
        string Url { get; set; }
    }
}