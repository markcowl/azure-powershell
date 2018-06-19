namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(CallbackConfigTypeConverter))]
    public partial class CallbackConfig
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.ICallbackConfig FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(CallbackConfigTypeConverter))]
    public partial interface ICallbackConfig {

    }
}