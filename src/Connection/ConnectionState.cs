namespace NoRealm.Phi.DataEngine.Abstractions
{
    /// <summary>
    /// Represent connection state
    /// </summary>
    public enum ConnectionState
    {
        /// <summary>The connection is in progress.</summary>
        Connecting,

        /// <summary>The connection is broken.</summary>
        Broken,

        /// <summary>The connection is open.</summary>
        Open,

        /// <summary>The connection is closed.</summary>
        Closed,

        /// <summary>The connection is executing a statement.</summary>
        Executing
    }
}
