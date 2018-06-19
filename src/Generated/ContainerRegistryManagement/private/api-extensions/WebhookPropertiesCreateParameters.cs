namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(WebhookPropertiesCreateParametersTypeConverter))]
    public partial class WebhookPropertiesCreateParameters
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IWebhookPropertiesCreateParameters FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(WebhookPropertiesCreateParametersTypeConverter))]
    public partial interface IWebhookPropertiesCreateParameters {

    }
}