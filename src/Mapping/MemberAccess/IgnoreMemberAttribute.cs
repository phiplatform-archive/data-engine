using System;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Mark a member to be ignored during mapping
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class IgnoreMemberAttribute : Attribute
    {
        /// <summary>
        /// initialize new instance
        /// </summary>
        public IgnoreMemberAttribute()
        {
        }
    }
}
