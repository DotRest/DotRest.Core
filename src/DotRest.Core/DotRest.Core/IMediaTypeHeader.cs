namespace DotRest
{
    /// <summary>
    /// Content type header interface.
    /// </summary>
    public interface IMediaTypeHeader
    {
        /// <summary>
        /// Gets the character set.
        /// </summary>
        /// <value>Character set.</value>
        string CharSet { get; }

        /// <summary>
        /// Gets the content media type.
        /// </summary>
        /// <value>Media type.</value>
        string MediaType { get; }
    }
}
