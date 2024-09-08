namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the string is a valid phone number.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string is a valid phone number; otherwise, false.</returns>
        public static bool IsValidPhoneNumber(this string @this)
        {
            return Regex.IsMatch(@this, @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$");
        }
    }
}