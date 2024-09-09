namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Removes all HTML tags from the input string.
        /// </summary>
        /// <param name="input">The string containing HTML to process.</param>
        /// <returns>A new string with all HTML tags removed.</returns>
        public static string RemoveHtmlTags(this string input)
        {
            return System.Text.RegularExpressions.Regex.Replace(input, @"<[^>]+>", string.Empty);
        }
    }
}