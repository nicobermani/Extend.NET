namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Unescapes a string that has been escaped for use in a regular expression.
        /// </summary>
        /// <param name="this">The escaped string to unescape.</param>
        /// <returns>The unescaped string.</returns>
        public static string ToUnescapedString(this string @this)
        {
            return Regex.Unescape(@this);
        }
    }
}