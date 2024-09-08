namespace Extend.NET.String
{
    using System.IO.Compression;
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Decompresses a GZip compressed string.
        /// </summary>
        /// <param name="this">The compressed string (Base64-encoded).</param>
        /// <returns>The decompressed string.</returns>
        public static string FromCompressed(this string @this)
        {
            var gZipBuffer = Convert.FromBase64String(@this);
            using (var memoryStream = new MemoryStream())
            {
                var dataLength = BitConverter.ToInt32(gZipBuffer, 0);
                memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

                var buffer = new byte[dataLength];

                memoryStream.Position = 0;
                using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    gZipStream.Read(buffer, 0, buffer.Length);
                }

                return Encoding.UTF8.GetString(buffer);
            }
        }
    }
}