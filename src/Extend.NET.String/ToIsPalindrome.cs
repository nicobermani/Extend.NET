namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Checks if the string is a palindrome (reads the same forwards and backwards).
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string is a palindrome; otherwise, false.</returns>
        public static bool ToIsPalindrome(this string @this)
        {
            string cleaned = new string(@this.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            return cleaned.SequenceEqual(cleaned.Reverse());
        }
    }
}