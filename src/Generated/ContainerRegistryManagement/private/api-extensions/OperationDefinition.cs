namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(OperationDefinitionTypeConverter))]
    public partial class OperationDefinition
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IOperationDefinition FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(OperationDefinitionTypeConverter))]
    public partial interface IOperationDefinition {

    }
}