namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all non-alphabetic characters in the string with a specified character.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="replacementChar">The character to replace non-alphabetic characters with.</param>
        /// <returns>A new string with all non-alphabetic characters replaced.</returns>
        public static string ToReplaceNonAlphabetic(this string @this, char replacementChar)
        {
            return new string(@this.Select(c => char.IsLetter(c) ? c : replacementChar).ToArray());
        }
    }
}