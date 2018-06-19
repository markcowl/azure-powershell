namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryTypeConverter))]
    public partial class Registry
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistry FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryTypeConverter))]
    public partial interface IRegistry {

    }
}