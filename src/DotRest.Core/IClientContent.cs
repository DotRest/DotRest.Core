using System;
using System.IO;
using System.Threading.Tasks;

namespace DotRest
{
    /// <summary>
    /// Client content interface.
    /// </summary>
    public interface IClientContent : IDisposable
    {
        /// <summary>
        /// Gets the content headers.
        /// </summary>
        /// <value>Content headers.</value>
        IContentHeaders Headers { get; }

        /// <summary>
        /// Reads as stream.
        /// </summary>
        /// <returns>Stream.</returns>
        Task<Stream> ReadAsStreamAsync();
    }
}
