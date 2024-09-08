using System.Globalization;

namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to title case.
        /// </summary>
        /// <param name="str">The string to convert.</param>
        /// <param name="culture">The culture to use for conversion. If null, uses the current culture.</param>
        /// <returns>The string in title case.</returns>
        public static string ToTitleCase(this string str, CultureInfo culture = null)
        {
            culture ??= CultureInfo.CurrentCulture;
            return culture.TextInfo.ToTitleCase(str.ToLower(culture));
        }
    }
}