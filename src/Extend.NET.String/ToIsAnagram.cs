namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Checks if the string is an anagram of another string.
        /// </summary>
        /// <param name="this">The first string.</param>
        /// <param name="other">The second string to compare with.</param>
        /// <returns>True if the strings are anagrams of each other; otherwise, false.</returns>
        public static bool ToIsAnagram(this string @this, string other)
        {
            if (string.IsNullOrEmpty(@this) || string.IsNullOrEmpty(other) || @this.Length != other.Length)
                return false;

            var thisChars = @this.ToLower().Where(char.IsLetterOrDigit).OrderBy(c => c);
            var otherChars = other.ToLower().Where(char.IsLetterOrDigit).OrderBy(c => c);

            return thisChars.SequenceEqual(otherChars);
        }
    }
}