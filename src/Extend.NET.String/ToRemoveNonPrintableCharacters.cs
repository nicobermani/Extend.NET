namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all non-printable characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with non-printable characters removed.</returns>
        public static string ToRemoveNonPrintableCharacters(this string @this)
        {
            return Regex.Replace(@this, @"[^\u0020-\u007E]", string.Empty);
        }
    }
}