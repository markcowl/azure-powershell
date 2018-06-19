namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class RegistryProperties : Sample.API.Models.IRegistryProperties, Microsoft.Rest.ClientRuntime.IValidates
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
        /// <summary>Backing field for CreationDate property</summary>
        private System.DateTime? _creationDate;

        /// <summary>The creation date of the container registry in ISO8601 format.</summary>
        public System.DateTime? CreationDate
        {
            get
            {
                return this._creationDate;
            }
            set
            {
                this._creationDate = value;
            }
        }
        /// <summary>Backing field for LoginServer property</summary>
        private string _loginServer;

        /// <summary>The URL that can be used to log into the container registry.</summary>
        public string LoginServer
        {
            get
            {
                return this._loginServer;
            }
            set
            {
                this._loginServer = value;
            }
        }
        /// <summary>Backing field for ProvisioningState property</summary>
        private Sample.API.Support.ProvisioningState _provisioningState;

        /// <summary>
        /// The provisioning state of the container registry at the time the operation was called.
        /// </summary>
        public Sample.API.Support.ProvisioningState ProvisioningState
        {
            get
            {
                return this._provisioningState;
            }
            set
            {
                this._provisioningState = value;
            }
        }
        /// <summary>Backing field for Status property</summary>
        private Sample.API.Models.IStatus _status;

        /// <summary>The status of the container registry at the time the operation was called.</summary>
        public Sample.API.Models.IStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        /// <summary>Backing field for StorageAccount property</summary>
        private Sample.API.Models.IStorageAccountProperties _storageAccount;

        /// <summary>
        /// The properties of the storage account for the container registry. Only applicable to Classic SKU.
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
        public static Sample.API.Models.IRegistryProperties FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new RegistryProperties(json) : null;
        }
        /// <param name="json"> </param>
        internal RegistryProperties(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.BooleanProperty("adminUserEnabled", ref this._adminUserEnabled);
            json.StringProperty("creationDate", ref this._creationDate);
            json.StringProperty("loginServer", ref this._loginServer);
            json.SafeAdd( "provisioningState", Carbon.Json.JsonString.Create(this._provisioningState));
            json.SafeAdd( "status", this._status?.ToJson());
            json.SafeAdd( "storageAccount", this._storageAccount?.ToJson());
            AfterFromJson(json);
        }
        public RegistryProperties()
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
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "creationDate", Carbon.Json.JsonString.CreateDateTime(CreationDate));
            }
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "loginServer", Carbon.Json.JsonString.Create(LoginServer));
            }
            if(serializationMode.HasFlag(Microsoft.Rest.ClientRuntime.JsonMode.IncludeReadOnly))
            {
                result.SafeAdd( "provisioningState", Carbon.Json.JsonString.Create(ProvisioningState));
            }
            result.SafeAdd( "status", Status?.ToJson());
            result.SafeAdd( "storageAccount", StorageAccount?.ToJson());
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertObjectIsValid(nameof(Status), Status);
            await listener.AssertObjectIsValid(nameof(StorageAccount), StorageAccount);
        }
    }
    public partial interface IRegistryProperties : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        bool? AdminUserEnabled { get; set; }
        System.DateTime? CreationDate { get; set; }
        string LoginServer { get; set; }
        Sample.API.Support.ProvisioningState ProvisioningState { get; set; }
        Sample.API.Models.IStatus Status { get; set; }
        Sample.API.Models.IStorageAccountProperties StorageAccount { get; set; }
    }
}