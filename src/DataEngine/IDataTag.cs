using NoRealm.Phi.Shared.Features;

namespace NoRealm.Phi.DataEngine.Abstractions
{
    /// <summary>
    /// The information for specific data source
    /// </summary>
    public interface IDataTag
    {
        /// <summary>
        /// Get associated features
        /// </summary>
        IFeatureCollection Features { get; }
    }
}
