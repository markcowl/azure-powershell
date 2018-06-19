namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(WebhookPropertiesUpdateParametersTypeConverter))]
    public partial class WebhookPropertiesUpdateParameters
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IWebhookPropertiesUpdateParameters FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(WebhookPropertiesUpdateParametersTypeConverter))]
    public partial interface IWebhookPropertiesUpdateParameters {

    }
}