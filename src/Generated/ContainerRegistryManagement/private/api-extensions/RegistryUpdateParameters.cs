namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryUpdateParametersTypeConverter))]
    public partial class RegistryUpdateParameters
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryUpdateParameters FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryUpdateParametersTypeConverter))]
    public partial interface IRegistryUpdateParameters {

    }
}