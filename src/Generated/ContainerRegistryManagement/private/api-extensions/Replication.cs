namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(ReplicationTypeConverter))]
    public partial class Replication
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IReplication FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ReplicationTypeConverter))]
    public partial interface IReplication {

    }
}