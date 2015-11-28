namespace DotRest
{
    /// <summary>
    /// Client factory.
    /// </summary>
    public interface IClientFactory<TSettings>
        where TSettings : IClientSettings
    {
        /// <summary>
        /// Creates a new instance of a client.
        /// </summary>
        /// <param name="settings">Client settings.</param>
        /// <returns>Client.</returns>
        IClient CreateClient(TSettings settings);
    }
}
