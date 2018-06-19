namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class RegistryPropertiesUpdateParameters : Sample.API.Models.IRegistryPropertiesUpdateParameters, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for AdminUserEnabled property</summary>
        private bool? _adminUserEnabled;

        /// <summary>The value that indicates whether the admin user is enabled.</summary>
        public bool? AdminUserEnabled
        {
            get
            {
                return this._adminUserEnabled;
            }
            set
            {
                this._adminUserEnabled = value;
            }
        }
        /// <summary>Backing field for StorageAccount property</summary>
        private Sample.API.Models.IStorageAccountProperties _storageAccount;

        /// <summary>
        /// The parameters of a storage account for the container registry. Only applicable to Classic SKU. If specified, the storage
        /// account must be in the same physical location as the container registry.
        /// </summary>
        public Sample.API.Models.IStorageAccountProperties StorageAccount
        {
            get
            {
                return this._storageAccount;
            }
            set
            {
                this._storageAccount = value;
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
        public static Sample.API.Models.IRegistryPropertiesUpdateParameters FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new RegistryPropertiesUpdateParameters(json) : null;
        }
        /// <param name="json"> </param>
        internal RegistryPropertiesUpdateParameters(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.BooleanProperty("adminUserEnabled", ref this._adminUserEnabled);
            json.SafeAdd( "storageAccount", this._storageAccount?.ToJson());
            AfterFromJson(json);
        }
        public RegistryPropertiesUpdateParameters()
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
            result.SafeAdd( "adminUserEnabled", Carbon.Json.JsonBoolean.Create(AdminUserEnabled));
            result.SafeAdd( "storageAccount", StorageAccount?.ToJson());
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertObjectIsValid(nameof(StorageAccount), StorageAccount);
        }
    }
    public partial interface IRegistryPropertiesUpdateParameters : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        bool? AdminUserEnabled { get; set; }
        Sample.API.Models.IStorageAccountProperties StorageAccount { get; set; }
    }
}