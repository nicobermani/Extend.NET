namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all non-printable characters in the string with a specified character.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="replacementChar">The character to replace non-printable characters with.</param>
        /// <returns>The string with non-printable characters replaced.</returns>
        public static string ToReplaceNonPrintableCharacters(this string @this, char replacementChar = '?')
        {
            return Regex.Replace(@this, @"[^\u0020-\u007E]", replacementChar.ToString());
        }
    }
}