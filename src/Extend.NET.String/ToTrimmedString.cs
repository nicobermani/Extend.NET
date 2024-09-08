namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Trims the string and replaces multiple whitespace characters with a single space.
        /// </summary>
        /// <param name="this">The string to trim and normalize.</param>
        /// <returns>A trimmed and normalized string.</returns>
        public static string ToTrimmedString(this string @this)
        {
            return System.Text.RegularExpressions.Regex.Replace(@this.Trim(), @"\s+", " ");
        }
    }
}