using System;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// The mapping engine.
    /// </summary>
    public interface IMapEngine
    {
        /// <summary>
        /// map record to object.
        /// </summary>
        /// <param name="targetType">type to hold data.</param>
        /// <param name="record">record data.</param>
        /// <returns>mapped object.</returns>
        /// <exception cref="MappingException">when a property couldn't be mapped.</exception>
        object Map(Type targetType, IRecord record);
    }
}
