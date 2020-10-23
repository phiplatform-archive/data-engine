using System;

namespace NoRealm.Phi.DataEngine.Abstractions
{
    /// <summary>
    /// Represent connection to a data source
    /// </summary>
    public interface IConnection : IDisposable
    {
        /// <summary>
        /// Get connection id.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Gets the time to wait while trying to connect.
        /// </summary>
        int ConnectionTimeout { get; }

        /// <summary>
        /// Open a connection.
        /// </summary>
        void Open();

        /// <summary>
        /// Close a connection.
        /// </summary>
        void Close();

        /// <summary>
        /// Get connection state.
        /// </summary>
        ConnectionState State { get; }
    }
}
