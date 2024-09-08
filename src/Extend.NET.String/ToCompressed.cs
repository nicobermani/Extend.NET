namespace Extend.NET.String
{
    using System.IO.Compression;
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Compresses the string using GZip compression.
        /// </summary>
        /// <param name="this">The string to compress.</param>
        /// <returns>The compressed string as a Base64-encoded string.</returns>
        public static string ToCompressed(this string @this)
        {
            var buffer = Encoding.UTF8.GetBytes(@this);
            using (var memoryStream = new MemoryStream())
            {
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
                {
                    gZipStream.Write(buffer, 0, buffer.Length);
                }
                return Convert.ToBase64String(memoryStream.ToArray());
            }
        }
    }
}