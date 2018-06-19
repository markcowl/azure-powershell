namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(TargetTypeConverter))]
    public partial class Target
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.ITarget FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(TargetTypeConverter))]
    public partial interface ITarget {

    }
}