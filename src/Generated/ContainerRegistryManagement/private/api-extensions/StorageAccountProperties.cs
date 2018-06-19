namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(StorageAccountPropertiesTypeConverter))]
    public partial class StorageAccountProperties
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IStorageAccountProperties FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(StorageAccountPropertiesTypeConverter))]
    public partial interface IStorageAccountProperties {

    }
}