namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryPasswordTypeConverter))]
    public partial class RegistryPassword
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryPassword FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryPasswordTypeConverter))]
    public partial interface IRegistryPassword {

    }
}