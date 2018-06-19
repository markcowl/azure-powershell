namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryListResultTypeConverter))]
    public partial class RegistryListResult
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryListResult FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryListResultTypeConverter))]
    public partial interface IRegistryListResult {

    }
}