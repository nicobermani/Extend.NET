namespace Extend.NET.String
{
    using System.Globalization;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Capitalizes the first letter of each word in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with each word capitalized.</returns>
        public static string ToCapitalizeWords(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return @this;

            var textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(@this.ToLower());
        }
    }
}