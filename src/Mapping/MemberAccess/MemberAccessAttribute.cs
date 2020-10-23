using System;

namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Represent member access
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class MemberAccessAttribute : Attribute
    {
        /// <summary>
        /// initialize new instance
        /// </summary>
        /// <param name="memberAccess">member access</param>
        public MemberAccessAttribute(MemberAccess memberAccess = MemberAccess.ReadWrite)
            => MemberAccess = memberAccess;

        /// <summary>
        /// Get member access
        /// </summary>
        public MemberAccess MemberAccess { get; }
    }
}
