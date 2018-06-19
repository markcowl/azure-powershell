namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(RegistryNameStatusTypeConverter))]
    public partial class RegistryNameStatus
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IRegistryNameStatus FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(RegistryNameStatusTypeConverter))]
    public partial interface IRegistryNameStatus {

    }
}