namespace Sample.API.Support
{

    public struct SkuName : System.IEquatable<SkuName>
    {
        public static Sample.API.Support.SkuName Basic = @"Basic";
        public static Sample.API.Support.SkuName Classic = @"Classic";
        public static Sample.API.Support.SkuName Premium = @"Premium";
        public static Sample.API.Support.SkuName Standard = @"Standard";
        private string value {get;set;}
        /// <summary>Compares values of enum type SkuName</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.SkuName e)
        {
            return value.Equals(e.value);
        }
        /// <summary>Compares values of enum type SkuName (override for Object)</summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is SkuName && Equals((SkuName)obj);
        }
        /// <summary>Returns hashCode for enum SkuName</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <param name="underlyingValue"> </param>
        private SkuName(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Returns string representation for SkuName</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <summary>Implicit operator to convert string to SkuName</summary>
        /// <param name="value"> </param>
        public static implicit operator SkuName(string value)
        {
            return new SkuName(value);
        }
        /// <summary>Implicit operator to convert SkuName to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.SkuName e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum SkuName</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.SkuName e1, Sample.API.Support.SkuName e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum SkuName</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.SkuName e1, Sample.API.Support.SkuName e2)
        {
            return e2.Equals(e1);
        }
    }
}