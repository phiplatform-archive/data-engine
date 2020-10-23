namespace NoRealm.Phi.DataEngine.Abstractions
{
    /// <summary>
    /// Represent a parameter passed to <see cref="ICommand"/>.
    /// </summary>
    public interface IParameter
    {
        /// <summary>
        /// Get/Set parameter name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Get/Set parameter data type
        /// </summary>
        IDataType DataType { get; set; }

        /// <summary>
        /// Get/Set parameter value.
        /// </summary>
        object Value { get; set; }
    }
}
