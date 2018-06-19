namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(EventContentTypeConverter))]
    public partial class EventContent
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IEventContent FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(EventContentTypeConverter))]
    public partial interface IEventContent {

    }
}