using Yalla;

namespace DotRest
{
    /// <summary>
    /// Service context interface.
    /// </summary>
    public interface IServiceContext<TSettings>
        where TSettings : IClientSettings
    {
        /// <summary>
        /// Gets the log factory.
        /// </summary>
        /// <value>Log factory.</value>
        ILogFactory LogFactory
        {
            get;
        }

        /// <summary>
        /// Gets the serializer.
        /// </summary>
        /// <value>Serializer.</value>
        ISerializer Serializer
        {
            get;
        }

        /// <summary>
        /// Gets the client settings.
        /// </summary>
        /// <value>Client settings.</value>
        TSettings ClientSettings
        {
            get;
        }

        /// <summary>
        /// Gets the base URI.
        /// </summary>
        /// <value>Base URI.</value>
        System.Uri BaseUri
        {
            get;
        }

        /// <summary>
        /// Gets the path format.
        /// </summary>
        /// <value>Path format.</value>
        string PathFormat
        {
            get;
        }

        /// <summary>
        /// Creates a new instance of a client.
        /// </summary>
        /// <returns>Client.</returns>
        IClient CreateClient();
    }
}
