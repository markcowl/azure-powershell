namespace Sample.API.Support
{

    public struct SkuTier : System.IEquatable<SkuTier>
    {
        public static Sample.API.Support.SkuTier Basic = @"Basic";
        public static Sample.API.Support.SkuTier Classic = @"Classic";
        public static Sample.API.Support.SkuTier Premium = @"Premium";
        public static Sample.API.Support.SkuTier Standard = @"Standard";
        private string value {get;set;}
        /// <summary>Compares values of enum type SkuTier</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.SkuTier e)
        {
            return value.Equals(e.value);
        }
        /// <summary>Compares values of enum type SkuTier (override for Object)</summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is SkuTier && Equals((SkuTier)obj);
        }
        /// <summary>Returns hashCode for enum SkuTier</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <param name="underlyingValue"> </param>
        private SkuTier(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Returns string representation for SkuTier</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <summary>Implicit operator to convert string to SkuTier</summary>
        /// <param name="value"> </param>
        public static implicit operator SkuTier(string value)
        {
            return new SkuTier(value);
        }
        /// <summary>Implicit operator to convert SkuTier to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.SkuTier e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum SkuTier</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.SkuTier e1, Sample.API.Support.SkuTier e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum SkuTier</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.SkuTier e1, Sample.API.Support.SkuTier e2)
        {
            return e2.Equals(e1);
        }
    }
}