namespace NoRealm.Phi.DataEngine.Mapping
{
    /// <summary>
    /// represent key information in <see cref="IRecord"/>
    /// </summary>
    public interface IKey
    {
        /// <summary>
        /// Get key position
        /// </summary>
        int Ordinal { get; }

        /// <summary>
        /// Get key name
        /// </summary>
        string Name { get; }
    }
}
