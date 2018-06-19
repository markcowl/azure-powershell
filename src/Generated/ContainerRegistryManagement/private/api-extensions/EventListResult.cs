namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(EventListResultTypeConverter))]
    public partial class EventListResult
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IEventListResult FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(EventListResultTypeConverter))]
    public partial interface IEventListResult {

    }
}