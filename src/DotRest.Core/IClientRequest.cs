using System;

namespace DotRest
{
    /// <summary>
    /// Client request interface.
    /// </summary>
    public interface IClientRequest : IDisposable
    {
        /// <summary>
        /// Gets the request URI.
        /// </summary>
        /// <value>Request URI.</value>
        Uri RequestUri { get; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <value>Content.</value>
        IClientContent Content { get; }
    }
}
