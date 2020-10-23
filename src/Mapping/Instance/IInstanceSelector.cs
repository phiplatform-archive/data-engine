using System;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Represent a handler to conditionally select a type instance
    /// </summary>
    public interface IInstanceSelector
    {
        /// <summary>
        /// Get instance for specified key from input type
        /// </summary>
        /// <param name="keyName">key name.</param>
        /// <param name="requestedType">the requested type.</param>
        /// <param name="record">the record information.</param>
        /// <returns>optional instance which equal to or derived form input type.</returns>
        object GetInstance(string keyName, Type requestedType, IRecord record);
    }
}
