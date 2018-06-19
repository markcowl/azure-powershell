namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(ReplicationPropertiesTypeConverter))]
    public partial class ReplicationProperties
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IReplicationProperties FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ReplicationPropertiesTypeConverter))]
    public partial interface IReplicationProperties {

    }
}