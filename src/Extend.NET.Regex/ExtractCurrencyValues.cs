using System.Text.RegularExpressions;

namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Extracts currency values from the input string.
        /// Supports formats like $10.99, €20.50, £30, etc.
        /// </summary>
        /// <param name="input">The string to extract currency values from.</param>
        /// <returns>An array of strings containing all currency values found in the input.</returns>
        public static string[] ExtractCurrencyValues(this string input)
        {
            string pattern = @"[$€£¥]?\d+(?:\.\d{2})?";
            return System.Text.RegularExpressions.Regex.Matches(input, pattern)
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToArray();
        }
    }
}