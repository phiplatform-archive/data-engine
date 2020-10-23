using System;
using System.Collections.Generic;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Represent a set of values that grouped together as a unit
    /// </summary>
    public interface IRecord
    {
        /// <summary>
        /// Get record keys
        /// </summary>
        IReadOnlyList<IKey> Keys { get; }

        /// <summary>
        /// Get value by key name.
        /// </summary>
        /// <param name="name">key name.</param>
        /// <returns>
        /// return value is one of 3 types:
        /// 1) an explicit value if underlying type is primitive.
        /// 2) a value of type <see cref="IEnumerable{T}"/> if underlying type is array-like type.
        /// 3) a value of type <see cref="IRecord"/> if underlying type is another <see cref="IRecord"/>.
        /// </returns>
        /// <exception cref="KeyNotFoundException">if key name not found</exception>
        object this[string name] { get; }

        /// <summary>
        /// Get value by key ordinal.
        /// </summary>
        /// <param name="ordinal">key ordinal.</param>
        /// <returns>
        /// return value is one of 3 types:
        /// 1) an explicit value if underlying type is primitive.
        /// 2) a value of type <see cref="IEnumerable{T}"/> if underlying type is array-like type.
        /// 3) a value of type <see cref="IRecord"/> if underlying type is another <see cref="IRecord"/>.
        /// </returns>
        /// <exception cref="IndexOutOfRangeException">if key ordinal is invalid</exception>
        object this[int ordinal] { get; }
    }
}
