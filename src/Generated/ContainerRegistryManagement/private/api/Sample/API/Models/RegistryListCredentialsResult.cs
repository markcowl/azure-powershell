namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class RegistryListCredentialsResult : Sample.API.Models.IRegistryListCredentialsResult, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for Passwords property</summary>
        private Sample.API.Models.IRegistryPassword[] _passwords;

        /// <summary>The list of passwords for a container registry.</summary>
        public Sample.API.Models.IRegistryPassword[] Passwords
        {
            get
            {
                return this._passwords;
            }
            set
            {
                this._passwords = value;
            }
        }
        /// <summary>Backing field for Username property</summary>
        private string _username;

        /// <summary>The username for a container registry.</summary>
        public string Username
        {
            get
            {
                return this._username;
            }
            set
            {
                this._username = value;
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
        public static Sample.API.Models.IRegistryListCredentialsResult FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new RegistryListCredentialsResult(json) : null;
        }
        /// <param name="json"> </param>
        internal RegistryListCredentialsResult(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.ArrayProperty("passwords", ref this._passwords, __each => Sample.API.Models.RegistryPassword.FromJson(__each) );
            json.StringProperty("username", ref this._username);
            AfterFromJson(json);
        }
        public RegistryListCredentialsResult()
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
            result.SafeAdd( "passwords", Carbon.Json.XNodeArray.Create( Passwords, __each=> __each?.ToJson()));
            result.SafeAdd( "username", Carbon.Json.JsonString.Create(Username));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            if( Passwords != null )  {
                for(int __i = 0; __i< Passwords.Length; __i++) {
                    await listener.AssertObjectIsValid($"Passwords[{__i}]", Passwords[__i]);
                }
            }
        }
    }
    public partial interface IRegistryListCredentialsResult : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        Sample.API.Models.IRegistryPassword[] Passwords { get; set; }
        string Username { get; set; }
    }
}