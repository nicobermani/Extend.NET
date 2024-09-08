namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Checks if the string is a valid URL.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string is a valid URL; otherwise, false.</returns>
        public static bool IsValidUrl(this string @this)
        {
            string pattern = @"^(https?:\/\/)?([\da-z\.-]+)\.([a-z\.]{2,6})([\/\w \.-]*)*\/?$";
            return Regex.IsMatch(@this, pattern, RegexOptions.IgnoreCase);
        }
    }
}