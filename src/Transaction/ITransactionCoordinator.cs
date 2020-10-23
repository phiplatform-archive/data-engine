namespace NoRealm.Phi.DataEngine.Transaction
{
    /// <summary>
    /// Represent a coordinator manager for distributed transactions
    /// </summary>
    public interface ITransactionCoordinator
    {
        /// <summary>
        /// add a transaction to coordinator
        /// </summary>
        /// <param name="transaction">a transaction to add</param>
        void Enlist(ITransaction transaction);

        /// <summary>
        /// Commit all transactions.
        /// </summary>
        void CommitAll();

        /// <summary>
        /// Rollback all transactions.
        /// </summary>
        void RollbackAll();
    }
}
