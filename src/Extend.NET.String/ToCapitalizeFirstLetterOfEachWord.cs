namespace Extend.NET.String
{
    using System.Globalization;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Capitalizes the first letter of each word in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with the first letter of each word capitalized.</returns>
        public static string ToCapitalizeFirstLetterOfEachWord(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return @this;

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(@this.ToLower());
        }
    }
}