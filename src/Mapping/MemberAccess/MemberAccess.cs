namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Represent member access
    /// </summary>
    public enum MemberAccess
    {
        /// <summary>Access is prohibited</summary>
        None = 0,

        /// <summary>Access level is default to member type</summary>
        Default,

        /// <summary>Access level is Read only</summary>
        Read,

        /// <summary>Access level is Write only</summary>
        Write,

        /// <summary>Access level is ReadWrite</summary>
        ReadWrite
    }
}
