namespace Sample.API.Support
{

    public struct ImportMode : System.IEquatable<ImportMode>
    {
        public static Sample.API.Support.ImportMode Force = @"Force";
        public static Sample.API.Support.ImportMode NoForce = @"NoForce";
        private string value {get;set;}
        /// <summary>Compares values of enum type ImportMode</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.ImportMode e)
        {
            return value.Equals(e.value);
        }
        /// <summary>Compares values of enum type ImportMode (override for Object)</summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is ImportMode && Equals((ImportMode)obj);
        }
        /// <summary>Returns hashCode for enum ImportMode</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <param name="underlyingValue"> </param>
        private ImportMode(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Returns string representation for ImportMode</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <summary>Implicit operator to convert string to ImportMode</summary>
        /// <param name="value"> </param>
        public static implicit operator ImportMode(string value)
        {
            return new ImportMode(value);
        }
        /// <summary>Implicit operator to convert ImportMode to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.ImportMode e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum ImportMode</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.ImportMode e1, Sample.API.Support.ImportMode e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum ImportMode</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.ImportMode e1, Sample.API.Support.ImportMode e2)
        {
            return e2.Equals(e1);
        }
    }
}