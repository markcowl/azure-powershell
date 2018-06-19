namespace Sample.API.Support
{

    public struct PasswordName : System.IEquatable<PasswordName>
    {
        public static Sample.API.Support.PasswordName Password = @"password";
        public static Sample.API.Support.PasswordName Password2 = @"password2";
        private string value {get;set;}
        /// <summary>Compares values of enum type PasswordName</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.PasswordName e)
        {
            return value.Equals(e.value);
        }
        /// <summary>Compares values of enum type PasswordName (override for Object)</summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is PasswordName && Equals((PasswordName)obj);
        }
        /// <summary>Returns hashCode for enum PasswordName</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <param name="underlyingValue"> </param>
        private PasswordName(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Returns string representation for PasswordName</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <summary>Implicit operator to convert string to PasswordName</summary>
        /// <param name="value"> </param>
        public static implicit operator PasswordName(string value)
        {
            return new PasswordName(value);
        }
        /// <summary>Implicit operator to convert PasswordName to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.PasswordName e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum PasswordName</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.PasswordName e1, Sample.API.Support.PasswordName e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum PasswordName</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.PasswordName e1, Sample.API.Support.PasswordName e2)
        {
            return e2.Equals(e1);
        }
    }
}