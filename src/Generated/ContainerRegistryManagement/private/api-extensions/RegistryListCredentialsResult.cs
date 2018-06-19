namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryListCredentialsResultTypeConverter))]
    public partial class RegistryListCredentialsResult
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryListCredentialsResult FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryListCredentialsResultTypeConverter))]
    public partial interface IRegistryListCredentialsResult {

    }
}