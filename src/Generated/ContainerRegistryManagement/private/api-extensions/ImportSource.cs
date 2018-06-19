namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(ImportSourceTypeConverter))]
    public partial class ImportSource
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IImportSource FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ImportSourceTypeConverter))]
    public partial interface IImportSource {

    }
}