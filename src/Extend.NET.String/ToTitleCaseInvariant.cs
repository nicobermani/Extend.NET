namespace Extend.NET.String
{
    using System.Globalization;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to title case using the invariant culture.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The string converted to title case.</returns>
        public static string ToTitleCaseInvariant(this string @this)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(@this.ToLower());
        }
    }
}