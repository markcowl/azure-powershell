namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class WebhookListResult : Sample.API.Models.IWebhookListResult, Microsoft.Rest.ClientRuntime.IValidates
    {
        /// <summary>Backing field for NextLink property</summary>
        private string _nextLink;

        /// <summary>The URI that can be used to request the next list of webhooks.</summary>
        public string NextLink
        {
            get
            {
                return this._nextLink;
            }
            set
            {
                this._nextLink = value;
            }
        }
        /// <summary>Backing field for Value property</summary>
        private Sample.API.Models.IWebhook[] _value;

        /// <summary>
        /// The list of webhooks. Since this list may be incomplete, the nextLink field should be used to request the next list of
        /// webhooks.
        /// </summary>
        public Sample.API.Models.IWebhook[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
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
        public static Sample.API.Models.IWebhookListResult FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new WebhookListResult(json) : null;
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
            result.SafeAdd( "nextLink", Carbon.Json.JsonString.Create(NextLink));
            result.SafeAdd( "value", Carbon.Json.XNodeArray.Create( Value, __each=> __each?.ToJson()));
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            if( Value != null )  {
                for(int __i = 0; __i< Value.Length; __i++) {
                    await listener.AssertObjectIsValid($"Value[{__i}]", Value[__i]);
                }
            }
        }
        /// <param name="json"> </param>
        internal WebhookListResult(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            json.StringProperty("nextLink", ref this._nextLink);
            json.ArrayProperty("value", ref this._value, __each => Sample.API.Models.Webhook.FromJson(__each) );
            AfterFromJson(json);
        }
        public WebhookListResult()
        {
        }
    }
    public partial interface IWebhookListResult : Microsoft.Rest.ClientRuntime.IJsonSerializable {
        string NextLink { get; set; }
        Sample.API.Models.IWebhook[] Value { get; set; }
    }
}