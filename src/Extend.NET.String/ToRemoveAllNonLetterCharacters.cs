namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all non-letter characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string containing only letter characters.</returns>
        public static string ToRemoveAllNonLetterCharacters(this string @this)
        {
            return Regex.Replace(@this, @"[^a-zA-Z]", string.Empty);
        }
    }
}