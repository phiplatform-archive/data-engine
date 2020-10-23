namespace NoRealm.Phi.DataEngine.Transaction
{
    /// <summary>
    /// Represent a connection which support transactions
    /// </summary>
    public interface ISupportTransaction
    {
        /// <summary>
        /// Gets the time to wait while trying to commit.
        /// </summary>
        int TransactionTimeout { get; }

        /// <summary>
        /// create a transaction with default option
        /// </summary>
        /// <returns>the transaction object</returns>
        ITransaction StartTransaction();

        /// <summary>
        /// create a transaction using input options
        /// </summary>
        /// <param name="transactionOption">transaction option</param>
        /// <returns>the transaction object</returns>
        ITransaction StartTransaction(ITransactionOption transactionOption);
    }
}
