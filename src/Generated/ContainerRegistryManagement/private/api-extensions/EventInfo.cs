namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(EventInfoTypeConverter))]
    public partial class EventInfo
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IEventInfo FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(EventInfoTypeConverter))]
    public partial interface IEventInfo {

    }
}