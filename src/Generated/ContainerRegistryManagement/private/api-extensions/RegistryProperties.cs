namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryPropertiesTypeConverter))]
    public partial class RegistryProperties
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryProperties FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryPropertiesTypeConverter))]
    public partial interface IRegistryProperties {

    }
}