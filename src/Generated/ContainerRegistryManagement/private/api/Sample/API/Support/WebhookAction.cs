namespace Sample.API.Support
{

    public struct WebhookAction : System.IEquatable<WebhookAction>
    {
        public static Sample.API.Support.WebhookAction Delete = @"delete";
        public static Sample.API.Support.WebhookAction Push = @"push";
        private string value {get;set;}
        /// <summary>Compares values of enum type WebhookAction</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.WebhookAction e)
        {
            return value.Equals(e.value);
        }
        /// <summary>Compares values of enum type WebhookAction (override for Object)</summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is WebhookAction && Equals((WebhookAction)obj);
        }
        /// <summary>Returns hashCode for enum WebhookAction</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <summary>Returns string representation for WebhookAction</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <param name="underlyingValue"> </param>
        private WebhookAction(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Implicit operator to convert string to WebhookAction</summary>
        /// <param name="value"> </param>
        public static implicit operator WebhookAction(string value)
        {
            return new WebhookAction(value);
        }
        /// <summary>Implicit operator to convert WebhookAction to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.WebhookAction e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum WebhookAction</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.WebhookAction e1, Sample.API.Support.WebhookAction e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum WebhookAction</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.WebhookAction e1, Sample.API.Support.WebhookAction e2)
        {
            return e2.Equals(e1);
        }
    }
}