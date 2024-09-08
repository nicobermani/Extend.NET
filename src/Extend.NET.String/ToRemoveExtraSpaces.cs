namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes extra spaces between words, leaving only single spaces.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with extra spaces removed.</returns>
        public static string ToRemoveExtraSpaces(this string @this)
        {
            return Regex.Replace(@this, @"\s+", " ").Trim();
        }
    }
}