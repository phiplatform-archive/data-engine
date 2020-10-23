using NoRealm.Phi.DataEngine.Abstractions;
using System;

namespace NoRealm.Phi.DataEngine.Transaction
{
    /// <summary>
    /// Represent a transaction
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// Get transaction Id
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// get the connection on which this transaction act
        /// </summary>
        IConnection Connection { get; }

        /// <summary>
        /// get transaction options
        /// </summary>
        ITransactionOption Options { get; }

        /// <summary>
        /// Commit the transaction.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollback the transaction.
        /// </summary>
        void Rollback();
    }
}
