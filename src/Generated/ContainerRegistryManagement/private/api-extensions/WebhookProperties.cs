namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(WebhookPropertiesTypeConverter))]
    public partial class WebhookProperties
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IWebhookProperties FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(WebhookPropertiesTypeConverter))]
    public partial interface IWebhookProperties {

    }
}