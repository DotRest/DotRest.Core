using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DotRest
{
    /// <summary>
    /// Client interface.
    /// </summary>
    public interface IClient : IDisposable
    {
        /// <summary>
        /// Creates a new instance of a query content.
        /// </summary>
        /// <param name="query">Key/value pairs.</param>
        /// <returns>Client content.</returns>
        IClientContent CreateContent(IEnumerable<KeyValuePair<string, string>> query);

        /// <summary>
        /// Creates a new instance of a client request.
        /// </summary>
        /// <param name="method">HTTP method.</param>
        /// <param name="uri">URI.</param>
        /// <returns>Client request.</returns>
        IClientRequest CreateRequest(string method, Uri uri);

        /// <summary>
        /// Creates a new instance of a client request.
        /// </summary>
        /// <param name="method">HTTP method.</param>
        /// <param name="uri">URI.</param>
        /// <returns>Client request.</returns>
        IClientRequest CreateRequest(string method, string uri);

        /// <summary>
        /// Creates a new instance of a client request.
        /// </summary>
        /// <param name="method">HTTP method.</param>
        /// <param name="uri">URI.</param>
        /// <param name="content">Content.</param>
        /// <returns>Client request.</returns>
        IClientRequest CreateRequest(string method, Uri uri, IClientContent content);

        /// <summary>
        /// Creates a new instance of a client request.
        /// </summary>
        /// <param name="method">HTTP method.</param>
        /// <param name="uri">URI.</param>
        /// <param name="content">Content.</param>
        /// <returns>Client request.</returns>
        IClientRequest CreateRequest(string method, string uri, IClientContent content);

        /// <summary>
        /// Creates a new instance of a stream content.
        /// </summary>
        /// <param name="stream">Stream.</param>
        /// <returns>Client content.</returns>
        IClientContent CreateContent(Stream stream);

        /// <summary>
        /// Creates a new instance of a stream content.
        /// </summary>
        /// <param name="stream">Stream.</param>
        /// <param name="bufferSize">Buffer size.</param>
        /// <returns>Client content.</returns>
        IClientContent CreateContent(Stream stream, int bufferSize);

        /// <summary>
        /// Creates a new instance of a content type header.
        /// </summary>
        /// <param name="mediaType">Media type.</param>
        /// <returns>Content type header.</returns>
        IMediaTypeHeader CreateMediaTypeHeader(string mediaType);

        /// <summary>
        /// Sends a GET request as an asynchronous operation.
        /// </summary>
        /// <arg name="uri">Request URI.</arg>
        /// <returns>Stream.</returns>
        Task<Stream> GetStreamAsync(Uri uri);

        /// <summary>
        /// Sends a GET request as an asynchronous operation.
        /// </summary>
        /// <arg name="uri">Request URI.</arg>
        /// <returns>Stream.</returns>
        Task<Stream> GetStreamAsync(string uri);

        /// <summary>
        /// Sends an HTTP request as an asynchronous operation.
        /// </summary>
        /// <arg name="request">Client request.</arg>
        /// <returns>Client response.</returns>
        Task<IClientResponse> SendAsync(IClientRequest request);

        /// <summary>
        /// Sends an HTTP request as an asynchronous operation.
        /// </summary>
        /// <arg name="request">Client request.</arg>
        /// <arg name="cancellationToken">Cancellation token.</arg>
        /// <returns>Client response.</returns>
        Task<IClientResponse> SendAsync(IClientRequest request, CancellationToken cancellationToken);
    }
}
