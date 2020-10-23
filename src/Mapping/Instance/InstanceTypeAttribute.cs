using System;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Specify the instance type to be used for property/field.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class InstanceTypeAttribute : Attribute
    {
        /// <summary>
        /// initialize new instance
        /// </summary>
        /// <param name="type">the instance type.</param>
        public InstanceTypeAttribute(Type type)
        {
            if (!type.IsClass)
                throw new ArgumentException($"type {type.FullName} must be a reference type.");

            Type = type;
        }

        /// <summary>
        /// Get instance type.
        /// </summary>
        public Type Type { get; }
    }
}
