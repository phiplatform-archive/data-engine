using System;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Contains extension methods to support <see cref="IMapEngine"/>
    /// </summary>
    public static class MappingExtensions
    {
        /// <summary>
        /// map record to object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mapEngine"><see cref="IMapEngine"/> instance</param>
        /// <param name="record">record data.</param>
        /// <returns>mapped object.</returns>
        /// <exception cref="MappingException">when a property couldn't be mapped.</exception>
        public static T Map<T>(this IMapEngine mapEngine, IRecord record) where T : class
        {
            if (mapEngine == null)
                throw new ArgumentNullException(nameof(mapEngine));

            return (T)mapEngine.Map(typeof(T), record);
        }
    }
}
