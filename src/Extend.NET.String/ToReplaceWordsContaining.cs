namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all words containing a specified substring with a given replacement.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="substring">The substring to search for in words.</param>
        /// <param name="replacement">The string to replace matching words with.</param>
        /// <returns>A new string with words containing the specified substring replaced.</returns>
        public static string ToReplaceWordsContaining(this string @this, string substring, string replacement)
        {
            if (string.IsNullOrWhiteSpace(@this) || string.IsNullOrEmpty(substring))
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Select(word => word.Contains(substring, StringComparison.OrdinalIgnoreCase) ? replacement : word));
        }
    }
}