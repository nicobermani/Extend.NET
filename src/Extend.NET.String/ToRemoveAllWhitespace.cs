namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all whitespace characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with all whitespace removed.</returns>
        public static string ToRemoveAllWhitespace(this string @this)
        {
            return Regex.Replace(@this, @"\s+", string.Empty);
        }
    }
}