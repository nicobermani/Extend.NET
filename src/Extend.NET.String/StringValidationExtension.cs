using System.Text.RegularExpressions;

namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
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
                // Use a more comprehensive regex pattern for email validation
                return Regex.IsMatch(str,
                    @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}