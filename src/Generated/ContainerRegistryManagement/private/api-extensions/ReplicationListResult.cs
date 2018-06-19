namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(ReplicationListResultTypeConverter))]
    public partial class ReplicationListResult
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IReplicationListResult FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ReplicationListResultTypeConverter))]
    public partial interface IReplicationListResult {

    }
}