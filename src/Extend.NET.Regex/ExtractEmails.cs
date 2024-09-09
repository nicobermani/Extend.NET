using System.Text.RegularExpressions;

namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Extracts all email addresses from the input string.
        /// </summary>
        /// <param name="input">The string to extract email addresses from.</param>
        /// <returns>An array of strings containing all email addresses found in the input.</returns>
        public static string[] ExtractEmails(this string input)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            return System.Text.RegularExpressions.Regex.Matches(input, pattern)
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToArray();
        }
    }
}