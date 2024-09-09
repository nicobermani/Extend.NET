namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Determines whether the input string is a valid IPv4 address.
        /// </summary>
        /// <param name="input">The string to check.</param>
        /// <returns>True if the input is a valid IPv4 address; otherwise, false.</returns>
        public static bool IsValidIPv4Address(this string input)
        {
            string pattern = @"^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
        }
    }
}