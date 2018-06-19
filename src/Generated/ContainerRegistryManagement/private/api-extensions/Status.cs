namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(StatusTypeConverter))]
    public partial class Status
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(StatusTypeConverter))]
    public partial interface IStatus {

    }
}