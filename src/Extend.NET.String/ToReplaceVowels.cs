namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all vowels in the string with a specified character.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="replacementChar">The character to replace vowels with.</param>
        /// <returns>A new string with all vowels replaced by the specified character.</returns>
        public static string ToReplaceVowels(this string @this, char replacementChar)
        {
            return new string(@this.Select(c => "aeiouAEIOU".Contains(c) ? replacementChar : c).ToArray());
        }
    }
}