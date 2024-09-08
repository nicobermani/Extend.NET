namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Counts the number of vowels in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The number of vowels in the string.</returns>
        public static int ToCountVowels(this string @this)
        {
            return @this.Count(c => "aeiouAEIOU".Contains(c));
        }
    }
}