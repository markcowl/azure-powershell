namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(WebhookListResultTypeConverter))]
    public partial class WebhookListResult
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IWebhookListResult FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(WebhookListResultTypeConverter))]
    public partial interface IWebhookListResult {

    }
}