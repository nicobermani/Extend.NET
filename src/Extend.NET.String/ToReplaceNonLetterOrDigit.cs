namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all characters that are not letters or digits in the string with a specified character.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="replacementChar">The character to replace non-letter and non-digit characters with.</param>
        /// <returns>A new string with all non-letter and non-digit characters replaced.</returns>
        public static string ToReplaceNonLetterOrDigit(this string @this, char replacementChar)
        {
            return new string(@this.Select(c => char.IsLetterOrDigit(c) ? c : replacementChar).ToArray());
        }
    }
}