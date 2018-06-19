namespace Sample.API.Support
{

    public struct ProvisioningState : System.IEquatable<ProvisioningState>
    {
        public static Sample.API.Support.ProvisioningState Canceled = @"Canceled";
        public static Sample.API.Support.ProvisioningState Creating = @"Creating";
        public static Sample.API.Support.ProvisioningState Deleting = @"Deleting";
        public static Sample.API.Support.ProvisioningState Failed = @"Failed";
        public static Sample.API.Support.ProvisioningState Succeeded = @"Succeeded";
        public static Sample.API.Support.ProvisioningState Updating = @"Updating";
        private string value {get;set;}
        /// <summary>Compares values of enum type ProvisioningState</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.ProvisioningState e)
        {
            return value.Equals(e.value);
        }
        /// <summary>Compares values of enum type ProvisioningState (override for Object)</summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is ProvisioningState && Equals((ProvisioningState)obj);
        }
        /// <summary>Returns hashCode for enum ProvisioningState</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <param name="underlyingValue"> </param>
        private ProvisioningState(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Returns string representation for ProvisioningState</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <summary>Implicit operator to convert string to ProvisioningState</summary>
        /// <param name="value"> </param>
        public static implicit operator ProvisioningState(string value)
        {
            return new ProvisioningState(value);
        }
        /// <summary>Implicit operator to convert ProvisioningState to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.ProvisioningState e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum ProvisioningState</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.ProvisioningState e1, Sample.API.Support.ProvisioningState e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum ProvisioningState</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.ProvisioningState e1, Sample.API.Support.ProvisioningState e2)
        {
            return e2.Equals(e1);
        }
    }
}