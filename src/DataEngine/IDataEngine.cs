using NoRealm.Phi.DataEngine.Mapping;
using NoRealm.Phi.Shared.Features;
using System;
using System.Collections.Generic;

namespace NoRealm.Phi.DataEngine.Abstractions
{
    /// <summary>
    /// The data engine
    /// </summary>
    /// <typeparam name="TDataTag">data source tag type</typeparam>
    /// <typeparam name="TCommand">command type</typeparam>
    public interface IDataEngine<TDataTag, in TCommand> : IDisposable
        where TDataTag : class, IDataTag
        where TCommand : class, ICommand
    {
        /// <summary>
        /// Get engine features
        /// </summary>
        IFeatureCollection Features { get; }

        /// <summary>
        /// Execute a command.
        /// </summary>
        /// <param name="command">the command.</param>
        /// <returns>engine-defined result.</returns>
        object Execute(TCommand command);

        /// <summary>
        /// execute a statement and map the result to input type
        /// </summary>
        /// <typeparam name="T">type to hold result.</typeparam>
        /// <param name="command">the command.</param>
        /// <returns>an object with mapped data.</returns>
        T GetSingle<T>(TCommand command) where T: class;

        /// <summary>
        /// execute a statement and manually map the result to input type
        /// </summary>
        /// <typeparam name="T">type to hold result.</typeparam>
        /// <param name="command">the command.</param>
        /// <param name="mapper">a mapping function to map the data to generic type.</param>
        /// <returns>an object with mapped data.</returns>
        T GetSingle<T>(TCommand command, MappingDelegate<T> mapper) where T: class;

        /// <summary>
        /// execute a statement and get a sequence of mapped objects.
        /// </summary>
        /// <typeparam name="T">type hold data.</typeparam>
        /// <param name="command">the command.</param>
        /// <returns>a sequence of objects, empty sequence if command yield nothing.</returns>
        IEnumerable<T> GetAll<T>(TCommand command) where T : class;

        /// <summary>
        /// execute a statement and get a sequence of manually mapped objects.
        /// </summary>
        /// <typeparam name="T">type hold data.</typeparam>
        /// <param name="command">the command.</param>
        /// <param name="mapper">a mapping function to map the data to generic type.</param>
        /// <returns>a sequence of objects, empty sequence if command yield nothing.</returns>
        IEnumerable<T> GetAll<T>(TCommand command, MappingDelegate<T> mapper) where T : class;
    }
}
