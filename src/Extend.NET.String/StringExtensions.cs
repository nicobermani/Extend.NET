using System.Text.RegularExpressions;

namespace Extend.NET.String
{
    /// <summary>
    /// Provides extension methods for string manipulation and validation.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Truncates the string to a specified length and adds an ellipsis if truncated.
        /// </summary>
        /// <param name="str">The string to truncate.</param>
        /// <param name="maxLength">The maximum length of the string.</param>
        /// <returns>The truncated string.</returns>
        public static string Truncate(this string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str) || str.Length <= maxLength)
                return str;

            return str.Substring(0, maxLength - 3) + "...";
        }

        /// <summary>
        /// Converts the string to title case.
        /// </summary>
        /// <param name="str">The string to convert.</param>
        /// <returns>The string in title case.</returns>
        public static string ToTitleCase(this string str)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        /// <summary>
        /// Checks if the string is a valid email address.
        /// </summary>
        /// <param name="str">The string to check.</param>
        /// <returns>True if the string is a valid email address; otherwise, false.</returns>
        public static bool IsValidEmail(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            try
            {
                // Use a simple regex pattern for email validation
                return Regex.IsMatch(str,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        /// <summary>
        /// Removes all whitespace characters from the string.
        /// </summary>
        /// <param name="str">The string to remove whitespace from.</param>
        /// <returns>The string with all whitespace removed.</returns>
        public static string RemoveWhitespace(this string str)
        {
            return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }

        /// <summary>
        /// Reverses the characters in the string.
        /// </summary>
        /// <param name="str">The string to reverse.</param>
        /// <returns>The reversed string.</returns>
        public static string Reverse(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
