namespace DotRest
{
    /// <summary>
    /// Log provider.
    /// </summary>
    public interface ILogProvider
    {
        /// <summary>
        /// Returns a log associated with the provided object.
        /// </summary>
        /// <typeparam name="T">Type of object.</typeparam>
        /// <param name="obj">The object to associate with.</param>
        /// <value>Log.</value>
        ILog For<T>(T obj);
    }
}
