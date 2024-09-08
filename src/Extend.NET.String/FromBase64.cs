namespace Extend.NET.String
{
    using System.Text;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts a Base64 string back to its original string representation.
        /// </summary>
        /// <param name="this">The Base64 string to convert.</param>
        /// <returns>The original string decoded from Base64.</returns>
        public static string FromBase64(this string @this)
        {
            byte[] bytes = Convert.FromBase64String(@this);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}