namespace Sample.API.Support
{

    public struct WebhookStatus : System.IEquatable<WebhookStatus>
    {
        public static Sample.API.Support.WebhookStatus Disabled = @"disabled";
        public static Sample.API.Support.WebhookStatus Enabled = @"enabled";
        private string value {get;set;}
        /// <summary>Compares values of enum type WebhookStatus</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.WebhookStatus e)
        {
            return value.Equals(e.value);
        }
        /// <summary>Compares values of enum type WebhookStatus (override for Object)</summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is WebhookStatus && Equals((WebhookStatus)obj);
        }
        /// <summary>Returns hashCode for enum WebhookStatus</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <summary>Returns string representation for WebhookStatus</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <param name="underlyingValue"> </param>
        private WebhookStatus(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Implicit operator to convert string to WebhookStatus</summary>
        /// <param name="value"> </param>
        public static implicit operator WebhookStatus(string value)
        {
            return new WebhookStatus(value);
        }
        /// <summary>Implicit operator to convert WebhookStatus to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.WebhookStatus e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum WebhookStatus</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.WebhookStatus e1, Sample.API.Support.WebhookStatus e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum WebhookStatus</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.WebhookStatus e1, Sample.API.Support.WebhookStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}