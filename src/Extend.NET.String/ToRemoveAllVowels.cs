namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all vowels from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with all vowels removed.</returns>
        public static string ToRemoveAllVowels(this string @this)
        {
            return new string(@this.Where(c => !"aeiouAEIOU".Contains(c)).ToArray());
        }
    }
}