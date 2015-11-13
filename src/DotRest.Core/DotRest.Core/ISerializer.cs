using System;
using System.IO;

namespace DotRest
{
    /// <summary>
    /// Serializer interface.
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Serializes an object to a string.
        /// </summary>
        /// <typeparam name="T">Type of <paramref name="obj"/>.</typeparam>
        /// <param name="obj">Object.</param>
        /// <returns>Serialized value.</returns>
        string Serialize<T>(T obj);

        /// <summary>
        /// Serializes an object to a stream.
        /// </summary>
        /// <typeparam name="T">Type of <paramref name="obj"/>.</typeparam>
        /// <param name="stream">Stream.</param>
        /// <param name="obj">Object.</param>
        void Serialize<T>(Stream stream, T obj)
            where T : class;

        /// <summary>
        /// Deserializes an object from a stream.
        /// </summary>
        /// <typeparam name="T">Type of <paramref name="obj"/>.</typeparam>
        /// <param name="stream">Stream.</param>
        /// <param name="obj">Target object.</param>
        void Deserialize<T>(Stream stream, out T obj)
            where T : class;
    }
}
