namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RequestTypeConverter))]
    public partial class Request
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRequest FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RequestTypeConverter))]
    public partial interface IRequest {

    }
}