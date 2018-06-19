namespace Sample.API.Models
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    using Sample.API.Support;
    public partial class Event : Sample.API.Models.IEvent, Microsoft.Rest.ClientRuntime.IValidates
    {
        private Sample.API.Models.IEventInfo _eventInfo = new Sample.API.Models.EventInfo();
        /// <summary>Backing field for EventRequestMessage property</summary>
        private Sample.API.Models.IEventRequestMessage _eventRequestMessage;

        /// <summary>The event request message sent to the service URI.</summary>
        public Sample.API.Models.IEventRequestMessage EventRequestMessage
        {
            get
            {
                return this._eventRequestMessage;
            }
            set
            {
                this._eventRequestMessage = value;
            }
        }
        /// <summary>Backing field for EventResponseMessage property</summary>
        private Sample.API.Models.IEventResponseMessage _eventResponseMessage;

        /// <summary>The event response message received from the service URI.</summary>
        public Sample.API.Models.IEventResponseMessage EventResponseMessage
        {
            get
            {
                return this._eventResponseMessage;
            }
            set
            {
                this._eventResponseMessage = value;
            }
        }
        public string Id
        {
            get
            {
                return _eventInfo.Id;
            }
            set
            {
                _eventInfo.Id = value;
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
        /// <param name="json"> </param>
        internal Event(Carbon.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if(returnNow)
            {
                return;
            }
            _eventInfo = new Sample.API.Models.EventInfo(json);
            json.SafeAdd( "eventRequestMessage", this._eventRequestMessage?.ToJson());
            json.SafeAdd( "eventResponseMessage", this._eventResponseMessage?.ToJson());
            AfterFromJson(json);
        }
        public Event()
        {
        }
        /// <param name="node"> </param>
        public static Sample.API.Models.IEvent FromJson(Carbon.Json.JsonNode node)
        {
            return node is Carbon.Json.JsonObject json ? new Event(json) : null;
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
            _eventInfo?.ToJson(result, serializationMode);
            result.SafeAdd( "eventRequestMessage", EventRequestMessage?.ToJson());
            result.SafeAdd( "eventResponseMessage", EventResponseMessage?.ToJson());
            AfterToJson(ref result);
            return result;
        }
        /// <param name="listener"> </param>
        public async System.Threading.Tasks.Task Validate(Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(_eventInfo), _eventInfo);
            await listener.AssertObjectIsValid(nameof(_eventInfo), _eventInfo);
            await listener.AssertObjectIsValid(nameof(EventRequestMessage), EventRequestMessage);
            await listener.AssertObjectIsValid(nameof(EventResponseMessage), EventResponseMessage);
        }
    }
    public partial interface IEvent : Microsoft.Rest.ClientRuntime.IJsonSerializable, Sample.API.Models.IEventInfo {
        Sample.API.Models.IEventRequestMessage EventRequestMessage { get; set; }
        Sample.API.Models.IEventResponseMessage EventResponseMessage { get; set; }
    }
}