namespace Extend.NET.String
{
    using System.Globalization;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to proper case (first letter of each word capitalized).
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The string converted to proper case.</returns>
        public static string ToProperCase(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return @this;

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(@this.ToLower());
        }
    }
}