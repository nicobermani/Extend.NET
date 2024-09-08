namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Capitalizes the first letter of each sentence in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with the first letter of each sentence capitalized.</returns>
        public static string ToCapitalizeFirstLetterOfEachSentence(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return @this;

            return Regex.Replace(@this, @"(^|\.\s+)([a-z])", m => m.Groups[1].Value + char.ToUpper(m.Groups[2].Value[0]));
        }
    }
}