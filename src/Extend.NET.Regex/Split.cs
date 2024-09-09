namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Splits the input string into an array of substrings at the positions defined by a regular expression pattern.
        /// </summary>
        /// <param name="input">The input string to split.</param>
        /// <param name="pattern">The regular expression pattern to use for splitting.</param>
        /// <returns>An array of substrings.</returns>
        public static string[] Split(this string input, string pattern)
        {
            return System.Text.RegularExpressions.Regex.Split(input, pattern);
        }
    }
}