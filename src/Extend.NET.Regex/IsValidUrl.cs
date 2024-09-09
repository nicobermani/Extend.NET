using System.Text.RegularExpressions;

namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Determines whether the input string is a valid URL.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the input is a valid URL; otherwise, false.</returns>
        public static bool IsValidUrl(this string input)
        {
            string pattern = @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";
            return System.Text.RegularExpressions.Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase);
        }
    }
}