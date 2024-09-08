namespace Extend.NET.String
{
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to a byte array using UTF-8 encoding.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>A byte array representing the string in UTF-8 encoding.</returns>
        public static byte[] ToByteArray(this string @this)
        {
            return Encoding.UTF8.GetBytes(@this);
        }
    }
}