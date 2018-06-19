namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryUsageListResultTypeConverter))]
    public partial class RegistryUsageListResult
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryUsageListResult FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryUsageListResultTypeConverter))]
    public partial interface IRegistryUsageListResult {

    }
}