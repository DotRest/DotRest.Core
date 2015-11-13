namespace DotRest
{
    /// <summary>
    /// Content headers interface.
    /// </summary>
    public interface IContentHeaders
    {
        /// <summary>
        /// Gets the content type header.
        /// </summary>
        /// <value>Content type header.</value>
        IMediaTypeHeader ContentType { get; }
    }
}
