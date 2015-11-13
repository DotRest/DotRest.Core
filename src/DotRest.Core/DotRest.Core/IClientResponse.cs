using System;

namespace DotRest
{
    /// <summary>
    /// Client response interface.
    /// </summary>
    public interface IClientResponse : IDisposable
    {
        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <value>Content.</value>
        IClientContent Content { get; }

        /// <summary>
        /// Gets the status code of the response.
        /// </summary>
        /// <value>Status code.</value>
        int StatusCode { get; }

        /// <summary>
        /// Indicates whether the response is successful.
        /// </summary>
        /// <value><c>true</c> if the response is successful.</value>
        bool IsSuccessStatusCode { get; }

        /// <summary>
        /// Throws an exception if <see cref="IsSuccessStatusCode"/> is <c>false</c>.
        /// </summary>
        void EnsureSuccessStatusCode();

        /// <summary>
        /// Gets the reason phrase sent together with the status code.
        /// </summary>
        /// <value>Reason phrase.</value>
        string ReasonPhrase { get; }
    }
}
