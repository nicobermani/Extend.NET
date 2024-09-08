namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all non-ASCII characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with all non-ASCII characters removed.</returns>
        public static string ToRemoveNonAsciiCharacters(this string @this)
        {
            return new string(@this.Where(c => c <= 127).ToArray());
        }
    }
}