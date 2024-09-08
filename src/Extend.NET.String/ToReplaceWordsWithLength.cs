namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all words with a specified length in the string with a given replacement.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="length">The length of words to replace.</param>
        /// <param name="replacement">The string to replace the words with.</param>
        /// <returns>A new string with words of the specified length replaced.</returns>
        public static string ToReplaceWordsWithLength(this string @this, int length, string replacement)
        {
            if (string.IsNullOrWhiteSpace(@this) || length <= 0)
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Select(word => word.Length == length ? replacement : word));
        }
    }
}