namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(ActorTypeConverter))]
    public partial class Actor
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IActor FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(ActorTypeConverter))]
    public partial interface IActor {

    }
}