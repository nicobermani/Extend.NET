namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the specified string to title case (except for words that are entirely in uppercase, which are considered to be acronyms).
        /// </summary>
        /// <param name="this">The string to convert to title case.</param>
        /// <returns>The specified string converted to title case.</returns>
        public static string ToTitleCase(this string @this)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(@this.ToLower());
        }
    }
}