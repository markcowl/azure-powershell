namespace Sample.API.Models
{

    public class WebhookListResultTypeConverter : System.Management.Automation.PSTypeConverter
    {

        /// <param name="sourceValue"> </param>
        /// <param name="destinationType"> </param>
        public override bool CanConvertFrom(object sourceValue, System.Type destinationType) => CanConvertFrom(sourceValue);
        /// <param name="sourceValue"> </param>
        public static bool CanConvertFrom(dynamic sourceValue)
        {
            if(null == sourceValue)
            {
                return true;
            }
            try
            {
                if(sourceValue.GetType() == typeof(System.Management.Automation.PSObject))
                {
                    // does it have the properties we need
                }
                else if(sourceValue.GetType() == typeof(System.Collections.Hashtable))
                {
                    // a hashtable?
                }
                else
                {
                    // object
                }
            }
            catch
            {
                // Unable to use JSON pattern
            }
            return false;
        }
        /// <param name="sourceValue"> </param>
        /// <param name="destinationType"> </param>
        public override bool CanConvertTo(object sourceValue, System.Type destinationType) => false;
        /// <param name="sourceValue"> </param>
        /// <param name="destinationType"> </param>
        /// <param name="formatProvider"> </param>
        /// <param name="ignoreCase"> </param>
        public override object ConvertFrom(object sourceValue, System.Type destinationType, System.IFormatProvider formatProvider, bool ignoreCase) => ConvertFrom(sourceValue);
        /// <param name="sourceValue"> </param>
        public static object ConvertFrom(dynamic sourceValue)
        {
            if(null == sourceValue)
            {
                return null;
            }
            try
            {
                WebhookListResult.FromJsonString(typeof(string) == sourceValue.GetType() ? sourceValue : sourceValue.ToJsonString());
            }
            catch
            {
                // Unable to use JSON pattern
            }
            try
            {
                return new WebhookListResult
                {
                NextLink = sourceValue.NextLink,
                Value = sourceValue.Value,
                };
            }
            catch
            {
            }
            return null;
        }
        /// <param name="sourceValue"> </param>
        /// <param name="destinationType"> </param>
        /// <param name="formatProvider"> </param>
        /// <param name="ignoreCase"> </param>
        public override object ConvertTo(object sourceValue, System.Type destinationType, System.IFormatProvider formatProvider, bool ignoreCase) => null;
    }
}