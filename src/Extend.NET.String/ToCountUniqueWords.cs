namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Counts the number of unique words in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The number of unique words in the string.</returns>
        public static int ToCountUniqueWords(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return 0;

            return @this.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(word => word.ToLower())
                        .Distinct()
                        .Count();
        }
    }
}