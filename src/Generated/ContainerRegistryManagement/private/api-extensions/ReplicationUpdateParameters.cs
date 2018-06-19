namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(ReplicationUpdateParametersTypeConverter))]
    public partial class ReplicationUpdateParameters
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IReplicationUpdateParameters FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ReplicationUpdateParametersTypeConverter))]
    public partial interface IReplicationUpdateParameters {

    }
}