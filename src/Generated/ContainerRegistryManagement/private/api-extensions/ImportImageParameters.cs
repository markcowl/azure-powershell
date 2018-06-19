namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(ImportImageParametersTypeConverter))]
    public partial class ImportImageParameters
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IImportImageParameters FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ImportImageParametersTypeConverter))]
    public partial interface IImportImageParameters {

    }
}