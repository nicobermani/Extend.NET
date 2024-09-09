using System.Text.RegularExpressions;

namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Extracts all hashtags from the input string.
        /// </summary>
        /// <param name="input">The string to extract hashtags from.</param>
        /// <returns>An array of strings containing all hashtags found in the input.</returns>
        public static string[] ExtractHashtags(this string input)
        {
            return System.Text.RegularExpressions.Regex.Matches(input, @"#\w+")
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToArray();
        }
    }
}