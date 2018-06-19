namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(EventTypeConverter))]
    public partial class Event
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IEvent FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(EventTypeConverter))]
    public partial interface IEvent {

    }
}