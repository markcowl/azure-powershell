namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryUsageTypeConverter))]
    public partial class RegistryUsage
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryUsage FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryUsageTypeConverter))]
    public partial interface IRegistryUsage {

    }
}