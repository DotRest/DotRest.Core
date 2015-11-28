using Yalla;

namespace DotRest
{
    /// <summary>
    /// Service context.
    /// </summary>
    public sealed class ServiceContext<TSettings> : IServiceContext<TSettings>
        where TSettings : IClientSettings
    {
        private readonly ILogFactory logFactory;

        private readonly ISerializer serializer;

        private readonly IClientFactory<TSettings> clientFactory;

        private readonly TSettings clientSettings;

        private readonly System.Uri baseUri;

        private readonly string pathFormat;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceContext{TSettings}"/> class.
        /// </summary>
        /// <param name="logFactory">Log factory.</param>
        /// <param name="serializer">Serializer.</param>
        /// <param name="clientFactory">Client factory.</param>
        /// <param name="clientSettings">Client settings.</param>
        /// <param name="baseUri">Base URI.</param>
        /// <param name="pathFormat">URI path format.</param>
        public ServiceContext(ILogFactory logFactory, ISerializer serializer, IClientFactory<TSettings> clientFactory, TSettings clientSettings, System.Uri baseUri, string pathFormat)
        {
            this.logFactory = logFactory;
            this.serializer = serializer;
            this.clientFactory = clientFactory;
            this.clientSettings = clientSettings;
            this.baseUri = baseUri;
            this.pathFormat = pathFormat;
        }

        /// <summary>
        /// Gets the log factory.
        /// </summary>
        /// <value>Log factory.</value>
        public ILogFactory LogFactory
        {
            get
            {
                return this.logFactory;
            }
        }

        /// <summary>
        /// Gets the serializer.
        /// </summary>
        /// <value>Serializer.</value>
        public ISerializer Serializer
        {
            get
            {
                return this.serializer;
            }
        }

        /// <summary>
        /// Gets the client settings.
        /// </summary>
        /// <value>Client settings.</value>
        public TSettings ClientSettings
        {
            get
            {
                return this.clientSettings;
            }
        }

        /// <summary>
        /// Gets the base URI.
        /// </summary>
        /// <value>Base URI.</value>
        public System.Uri BaseUri
        {
            get
            {
                return this.baseUri;
            }
        }

        /// <summary>
        /// Gets the path format.
        /// </summary>
        /// <value>Path format.</value>
        public string PathFormat
        {
            get
            {
                return this.pathFormat;
            }
        }

        /// <summary>
        /// Creates a new instance of a client.
        /// </summary>
        /// <returns>Client.</returns>
        public IClient CreateClient()
        {
            return this.clientFactory.CreateClient(ClientSettings);
        }
    }
}
