using System;
using System.Collections.Generic;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Extension methods to support <see cref="IRecord"/>
    /// </summary>
    public static class RecordExtensions
    {
        /// <summary>
        /// get value by key name.
        /// </summary>
        /// <param name="record"><see cref="IRecord"/> instance</param>
        /// <param name="name">key name.</param>
        /// <returns>refer to indexer return value of <see cref="IRecord"/></returns>
        /// <exception cref="ArgumentNullException">if passed argument is null</exception>
        /// <exception cref="KeyNotFoundException">if key name not found</exception>
        public static object GetValue(this IRecord record, string name)
        {
            if (record == null)
                throw new ArgumentNullException(nameof(record));

            return record[name];
        }

        /// <summary>
        /// get value by key ordinal.
        /// </summary>
        /// <param name="record"><see cref="IRecord"/> instance</param>
        /// <param name="ordinal">key ordinal.</param>
        /// <returns>refer to indexer return value of <see cref="IRecord"/></returns>
        /// <exception cref="ArgumentNullException">if passed argument is null</exception>
        /// <exception cref="KeyNotFoundException">if key name not found</exception>
        public static object GetValue(this IRecord record, int ordinal)
        {
            if (record == null)
                throw new ArgumentNullException(nameof(record));

            return record[ordinal];
        }
    }
}
