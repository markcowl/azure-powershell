namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(SourceTypeConverter))]
    public partial class Source
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.ISource FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(SourceTypeConverter))]
    public partial interface ISource {

    }
}