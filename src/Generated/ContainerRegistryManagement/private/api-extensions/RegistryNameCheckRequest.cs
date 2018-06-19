namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryNameCheckRequestTypeConverter))]
    public partial class RegistryNameCheckRequest
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryNameCheckRequest FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryNameCheckRequestTypeConverter))]
    public partial interface IRegistryNameCheckRequest {

    }
}