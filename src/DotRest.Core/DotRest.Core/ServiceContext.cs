namespace DotRest
{
    /// <summary>
    /// Service context.
    /// </summary>
    public sealed class ServiceContext<TSettings> : IServiceContext<TSettings>
        where TSettings : IClientSettings
    {
        private readonly ILogProvider logProvider;

        private readonly ISerializer serializer;

        private readonly IClientFactory<TSettings> clientFactory;

        private readonly TSettings clientSettings;

        private readonly System.Uri baseUri;

        private readonly string pathFormat;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceContext{TSettings}"/> class.
        /// </summary>
        /// <param name="logProvider">Log provider.</param>
        /// <param name="serializer">Serializer.</param>
        /// <param name="clientFactory">Client factory.</param>
        /// <param name="clientSettings">Client settings.</param>
        /// <param name="baseUri">Base URI.</param>
        /// <param name="pathFormat">URI path format.</param>
        public ServiceContext(ILogProvider logProvider, ISerializer serializer, IClientFactory<TSettings> clientFactory, TSettings clientSettings, System.Uri baseUri, string pathFormat)
        {
            this.logProvider = logProvider;
            this.serializer = serializer;
            this.clientFactory = clientFactory;
            this.clientSettings = clientSettings;
            this.baseUri = baseUri;
            this.pathFormat = pathFormat;
        }

        /// <summary>
        /// Gets the log provider.
        /// </summary>
        /// <value>Log provider.</value>
        public ILogProvider LogProvider
        {
            get
            {
                return this.logProvider;
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
