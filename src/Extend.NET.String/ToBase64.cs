namespace Extend.NET.String
{
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to its Base64 representation.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The Base64 representation of the string.</returns>
        public static string ToBase64(this string @this)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(@this));
        }
    }
}