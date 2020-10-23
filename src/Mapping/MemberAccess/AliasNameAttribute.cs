using System;
using System.Collections.Generic;
using System.Linq;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Represent member additional names
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class AliasNameAttribute : Attribute
    {
        /// <summary>
        /// Initialize new instance with input values
        /// </summary>
        /// <param name="names">member additional names</param>
        /// <remarks>at least one name is required</remarks>
        public AliasNameAttribute(params string[] names)
        {
            var set = new HashSet<string>(names);

            if (set.Count == 0 || set.Count != names.Length || set.Any(string.IsNullOrWhiteSpace))
                throw new ArgumentException("names can not be null or empty and must have distinct values");

            Names = set.ToArray();
        }

        /// <summary>
        /// Get additional names
        /// </summary>
        public IReadOnlyList<string> Names { get; }
    }
}
