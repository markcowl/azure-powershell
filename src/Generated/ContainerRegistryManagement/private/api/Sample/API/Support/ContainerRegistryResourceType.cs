namespace Sample.API.Support
{

    public struct ContainerRegistryResourceType : System.IEquatable<ContainerRegistryResourceType>
    {
        public static Sample.API.Support.ContainerRegistryResourceType MicrosoftContainerRegistryRegistries = @"Microsoft.ContainerRegistry/registries";
        private string value {get;set;}
        /// <param name="underlyingValue"> </param>
        private ContainerRegistryResourceType(string underlyingValue)
        {
            this.value = underlyingValue;
        }
        /// <summary>Compares values of enum type ContainerRegistryResourceType</summary>
        /// <param name="e"> </param>
        public bool Equals(Sample.API.Support.ContainerRegistryResourceType e)
        {
            return value.Equals(e.value);
        }
        /// <summary>
        /// Compares values of enum type ContainerRegistryResourceType (override for Object)
        /// </summary>
        /// <param name="obj"> </param>
        public override bool Equals(object obj)
        {
            return obj is ContainerRegistryResourceType && Equals((ContainerRegistryResourceType)obj);
        }
        /// <summary>Returns hashCode for enum ContainerRegistryResourceType</summary>
        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }
        /// <summary>Returns string representation for ContainerRegistryResourceType</summary>
        public override string ToString()
        {
            return this.value;
        }
        /// <summary>Implicit operator to convert string to ContainerRegistryResourceType</summary>
        /// <param name="value"> </param>
        public static implicit operator ContainerRegistryResourceType(string value)
        {
            return new ContainerRegistryResourceType(value);
        }
        /// <summary>Implicit operator to convert ContainerRegistryResourceType to string</summary>
        /// <param name="e"> </param>
        public static implicit operator string(Sample.API.Support.ContainerRegistryResourceType e)
        {
            return e.value;
        }
        /// <summary>Overriding != operator for enum ContainerRegistryResourceType</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator !=(Sample.API.Support.ContainerRegistryResourceType e1, Sample.API.Support.ContainerRegistryResourceType e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum ContainerRegistryResourceType</summary>
        /// <param name="e1"> </param>
        /// <param name="e2"> </param>
        public static bool operator ==(Sample.API.Support.ContainerRegistryResourceType e1, Sample.API.Support.ContainerRegistryResourceType e2)
        {
            return e2.Equals(e1);
        }
    }
}