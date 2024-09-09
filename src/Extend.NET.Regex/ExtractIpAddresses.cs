using System.Text.RegularExpressions;

namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Extracts all IP addresses (IPv4) from the input string.
        /// </summary>
        /// <param name="input">The string to extract IP addresses from.</param>
        /// <returns>An array of strings containing all IP addresses found in the input.</returns>
        public static string[] ExtractIpAddresses(this string input)
        {
            string pattern = @"\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
            return System.Text.RegularExpressions.Regex.Matches(input, pattern)
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToArray();
        }
    }
}