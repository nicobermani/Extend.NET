namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Checks if the string is a valid email address.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string is a valid email address; otherwise, false.</returns>
        public static bool IsValidEmail(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return false;

            try
            {
                // Use a simple regex pattern for email validation
                return Regex.IsMatch(@this,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}