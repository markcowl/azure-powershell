namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(WebhookTypeConverter))]
    public partial class Webhook
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IWebhook FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(WebhookTypeConverter))]
    public partial interface IWebhook {

    }
}