namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(OperationDisplayDefinitionTypeConverter))]
    public partial class OperationDisplayDefinition
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IOperationDisplayDefinition FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(OperationDisplayDefinitionTypeConverter))]
    public partial interface IOperationDisplayDefinition {

    }
}