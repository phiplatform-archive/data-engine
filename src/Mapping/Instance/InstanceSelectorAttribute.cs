using System;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Specify the <see cref="IInstanceSelector"/> implementation which provide
    /// the property/field instance.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class InstanceSelectorAttribute : Attribute
    {
        /// <summary>
        /// initialize new instance
        /// </summary>
        /// <param name="type">instance selector type.</param>
        public InstanceSelectorAttribute(Type type)
        {
            if (!typeof(IInstanceSelector).IsAssignableFrom(type))
                throw new ArgumentException($"type {type.FullName} doesn't implement {typeof(IInstanceSelector).FullName}");

            if (!type.IsClass)
                throw new ArgumentException($"type {type.FullName} must be a reference type.");

            Type = type;
        }

        /// <summary>
        /// Get instance selector type
        /// </summary>
        public Type Type { get; }
    }
}
