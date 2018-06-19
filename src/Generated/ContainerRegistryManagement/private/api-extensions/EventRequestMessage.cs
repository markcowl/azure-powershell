namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(EventRequestMessageTypeConverter))]
    public partial class EventRequestMessage
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IEventRequestMessage FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(EventRequestMessageTypeConverter))]
    public partial interface IEventRequestMessage {

    }
}