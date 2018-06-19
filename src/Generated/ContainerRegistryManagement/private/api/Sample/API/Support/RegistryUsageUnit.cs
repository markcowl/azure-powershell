namespace Sample.API.Support
{

    public struct RegistryUsageUnit : System.IEquatable<RegistryUsageUnit>
    {
        public static Sample.API.Support.RegistryUsageUnit Bytes = @"Bytes";
        public static Sample.API.Support.RegistryUsageUnit Count = @"Count";
        private string value {get;set;}
        /// <summary>Compares values of enum type RegistryUsageUnit</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.RegistryUsageUnit e)
        {
            return value.Equals(e.value);
        }
        /// <summary>Compares values of enum type RegistryUsageUnit (override for Object)</summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is RegistryUsageUnit && Equals((RegistryUsageUnit)obj);
        }
        /// <summary>Returns hashCode for enum RegistryUsageUnit</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <param name="underlyingValue"> </param>
        private RegistryUsageUnit(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Returns string representation for RegistryUsageUnit</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <summary>Implicit operator to convert string to RegistryUsageUnit</summary>
        /// <param name="value"> </param>
        public static implicit operator RegistryUsageUnit(string value)
        {
            return new RegistryUsageUnit(value);
        }
        /// <summary>Implicit operator to convert RegistryUsageUnit to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.RegistryUsageUnit e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum RegistryUsageUnit</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.RegistryUsageUnit e1, Sample.API.Support.RegistryUsageUnit e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum RegistryUsageUnit</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.RegistryUsageUnit e1, Sample.API.Support.RegistryUsageUnit e2)
        {
            return e2.Equals(e1);
        }
    }
}