namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes HTML tags from the string.
        /// </summary>
        /// <param name="this">The string containing HTML to strip.</param>
        /// <returns>The string with HTML tags removed.</returns>
        public static string StripHtml(this string @this)
        {
            return Regex.Replace(@this, "<.*?>", string.Empty);
        }
    }
}