namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all non-ASCII characters in the string with a specified character.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="replacementChar">The character to replace non-ASCII characters with.</param>
        /// <returns>A new string with all non-ASCII characters replaced.</returns>
        public static string ToReplaceNonAsciiCharacters(this string @this, char replacementChar)
        {
            return new string(@this.Select(c => c <= 127 ? c : replacementChar).ToArray());
        }
    }
}