namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all non-alphabetic characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with all non-alphabetic characters removed.</returns>
        public static string ToRemoveNonAlphabetic(this string @this)
        {
            return new string(@this.Where(char.IsLetter).ToArray());
        }
    }
}