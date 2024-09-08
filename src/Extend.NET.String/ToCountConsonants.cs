namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Counts the number of consonants in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The number of consonants in the string.</returns>
        public static int ToCountConsonants(this string @this)
        {
            return @this.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c));
        }
    }
}