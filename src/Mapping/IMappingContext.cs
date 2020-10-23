namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// Represent a context to map data into .net objects
    /// </summary>
    public interface IMappingContext
    {
        /// <summary>
        /// Get current record.
        /// </summary>
        IRecord Record { get; }

        /// <summary>
        /// Get mapping engine instance.
        /// </summary>
        IMapEngine MapEngine { get; }

        /// <summary>
        /// get/set a value to stop further reading
        /// </summary>
        bool IsFinished { get; set; }
    }
}
