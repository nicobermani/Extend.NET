using System.Text.RegularExpressions;

namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Extracts time in HH:MM or HH:MM:SS format from the input string.
        /// </summary>
        /// <param name="input">The string to extract time from.</param>
        /// <returns>An array of strings containing all time values found in the input.</returns>
        public static string[] ExtractTimeFromString(this string input)
        {
            string pattern = @"\b(?:[01]\d|2[0-3]):[0-5]\d(?::[0-5]\d)?\b";
            return System.Text.RegularExpressions.Regex.Matches(input, pattern)
                        .Cast<Match>()
                        .Select(m => m.Value)
                        .ToArray();
        }
    }
}