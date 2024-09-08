namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all consonants from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with all consonants removed.</returns>
        public static string ToRemoveAllConsonants(this string @this)
        {
            return new string(@this.Where(c => "aeiouAEIOU".Contains(c) || !char.IsLetter(c)).ToArray());
        }
    }
}