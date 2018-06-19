namespace Sample.API.Models
{

    [System.ComponentModel.TypeConverter(typeof(WebhookCreateParametersTypeConverter))]
    public partial class WebhookCreateParameters
    {

        /// <param name="jsonText"> </param>
        public static Sample.API.Models.IWebhookCreateParameters FromJsonString(string jsonText) => FromJson(Carbon.Json.JsonNode.Parse(jsonText));
        public string ToJsonString() => ToJson(null, Microsoft.Rest.ClientRuntime.JsonMode.IncludeAll)?.ToString();
    }
    [System.ComponentModel.TypeConverter(typeof(WebhookCreateParametersTypeConverter))]
    public partial interface IWebhookCreateParameters {

    }
}