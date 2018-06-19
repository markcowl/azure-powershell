namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryPropertiesUpdateParametersTypeConverter))]
    public partial class RegistryPropertiesUpdateParameters
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryPropertiesUpdateParameters FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryPropertiesUpdateParametersTypeConverter))]
    public partial interface IRegistryPropertiesUpdateParameters {

    }
}