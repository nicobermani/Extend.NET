namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all non-alphanumeric characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with only alphanumeric characters.</returns>
        public static string ToRemoveNonAlphanumeric(this string @this)
        {
            return Regex.Replace(@this, @"[^a-zA-Z0-9]", string.Empty);
        }
    }
}