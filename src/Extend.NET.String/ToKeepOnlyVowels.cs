namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Keeps only the vowels in the string, removing all other characters.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string containing only the vowels from the original string.</returns>
        public static string ToKeepOnlyVowels(this string @this)
        {
            return new string(@this.Where(c => "aeiouAEIOU".Contains(c)).ToArray());
        }
    }
}