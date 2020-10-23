namespace NoRealm.Phi.DataEngine.Abstractions
{
    /// <summary>
    /// Represent a data engine provider
    /// </summary>
    public interface IDataEngineProvider
    {
        /// <summary>
        /// create or get a data engine instance
        /// </summary>
        /// <typeparam name="TDataTag">data source tag type</typeparam>
        /// <typeparam name="TCommand">command type</typeparam>
        /// <returns>a data engine instance</returns>
        IDataEngine<TDataTag, TCommand> GetInstance<TDataTag, TCommand>()
            where TDataTag : class, IDataTag
            where TCommand : class, ICommand;
    }
}
