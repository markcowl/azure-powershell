namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(OperationListResultTypeConverter))]
    public partial class OperationListResult
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IOperationListResult FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(OperationListResultTypeConverter))]
    public partial interface IOperationListResult {

    }
}