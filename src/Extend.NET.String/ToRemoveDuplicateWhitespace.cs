namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes duplicate whitespace characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with duplicate whitespace removed.</returns>
        public static string ToRemoveDuplicateWhitespace(this string @this)
        {
            return Regex.Replace(@this, @"\s+", " ").Trim();
        }
    }
}