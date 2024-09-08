namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Counts the number of occurrences of a substring within the string.
        /// </summary>
        /// <param name="this">The string to search in.</param>
        /// <param name="substring">The substring to search for.</param>
        /// <param name="stringComparison">The string comparison method to use.</param>
        /// <returns>The number of occurrences of the substring.</returns>
        public static int CountOccurrences(this string @this, string substring, StringComparison stringComparison = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(@this) || string.IsNullOrEmpty(substring))
                return 0;

            var count = 0;
            var position = 0;
            while ((position = @this.IndexOf(substring, position, stringComparison)) != -1)
            {
                count++;
                position += substring.Length;
            }
            return count;
        }
    }
}