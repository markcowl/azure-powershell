namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(EventResponseMessageTypeConverter))]
    public partial class EventResponseMessage
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IEventResponseMessage FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(EventResponseMessageTypeConverter))]
    public partial interface IEventResponseMessage {

    }
}