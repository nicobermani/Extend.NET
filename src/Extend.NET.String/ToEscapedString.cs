namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Escapes special characters in the string for use in a regular expression.
        /// </summary>
        /// <param name="this">The string to escape.</param>
        /// <returns>The escaped string.</returns>
        public static string ToEscapedString(this string @this)
        {
            return Regex.Escape(@this);
        }
    }
}