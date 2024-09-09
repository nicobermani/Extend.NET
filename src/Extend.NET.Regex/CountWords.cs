namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Counts the number of words in the input string.
        /// </summary>
        /// <param name="input">The string to count words in.</param>
        /// <returns>The number of words in the input string.</returns>
        public static int CountWords(this string input)
        {
            return System.Text.RegularExpressions.Regex.Matches(input, @"\b\w+\b").Count;
        }
    }
}