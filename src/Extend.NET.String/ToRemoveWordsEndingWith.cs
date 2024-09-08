namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all words ending with a specified suffix from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="suffix">The suffix to match for removal.</param>
        /// <returns>A new string with words ending with the specified suffix removed.</returns>
        public static string ToRemoveWordsEndingWith(this string @this, string suffix)
        {
            if (string.IsNullOrWhiteSpace(@this) || string.IsNullOrEmpty(suffix))
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Where(word => !word.EndsWith(suffix, StringComparison.OrdinalIgnoreCase)));
        }
    }
}