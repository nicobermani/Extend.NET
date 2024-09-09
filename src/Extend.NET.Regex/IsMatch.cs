namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Determines whether the specified regex pattern matches the input string.
        /// </summary>
        /// <param name="input">The input string to check.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <returns>True if the input matches the pattern; otherwise, false.</returns>
        public static bool IsMatch(this string input, string pattern)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
        }
    }
}