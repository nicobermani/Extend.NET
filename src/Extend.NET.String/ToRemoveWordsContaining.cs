namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all words containing a specified substring from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="substring">The substring to search for in words.</param>
        /// <returns>A new string with words containing the specified substring removed.</returns>
        public static string ToRemoveWordsContaining(this string @this, string substring)
        {
            if (string.IsNullOrWhiteSpace(@this) || string.IsNullOrEmpty(substring))
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Where(word => !word.Contains(substring, StringComparison.OrdinalIgnoreCase)));
        }
    }
}