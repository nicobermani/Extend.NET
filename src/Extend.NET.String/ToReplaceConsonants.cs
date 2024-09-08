namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all consonants in the string with a specified character.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="replacementChar">The character to replace consonants with.</param>
        /// <returns>A new string with all consonants replaced by the specified character.</returns>
        public static string ToReplaceConsonants(this string @this, char replacementChar)
        {
            return new string(@this.Select(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c) ? replacementChar : c).ToArray());
        }
    }
}