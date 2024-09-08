namespace Extend.NET.String
{
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts a byte array to a string using UTF-8 encoding.
        /// </summary>
        /// <param name="this">The byte array to convert.</param>
        /// <returns>A string representation of the byte array using UTF-8 encoding.</returns>
        public static string FromByteArray(this byte[] @this)
        {
            return Encoding.UTF8.GetString(@this);
        }
    }
}