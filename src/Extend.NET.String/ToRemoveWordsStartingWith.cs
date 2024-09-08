namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all words starting with a specified prefix from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="prefix">The prefix to match for removal.</param>
        /// <returns>A new string with words starting with the specified prefix removed.</returns>
        public static string ToRemoveWordsStartingWith(this string @this, string prefix)
        {
            if (string.IsNullOrWhiteSpace(@this) || string.IsNullOrEmpty(prefix))
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Where(word => !word.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)));
        }
    }
}