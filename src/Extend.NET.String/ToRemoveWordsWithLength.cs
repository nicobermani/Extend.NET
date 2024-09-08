namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all words with a specified length from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="length">The length of words to remove.</param>
        /// <returns>A new string with words of the specified length removed.</returns>
        public static string ToRemoveWordsWithLength(this string @this, int length)
        {
            if (string.IsNullOrWhiteSpace(@this) || length <= 0)
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Where(word => word.Length != length));
        }
    }
}