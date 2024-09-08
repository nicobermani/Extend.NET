namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all characters that are not letters or digits from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with all non-letter and non-digit characters removed.</returns>
        public static string ToRemoveNonLetterOrDigit(this string @this)
        {
            return new string(@this.Where(char.IsLetterOrDigit).ToArray());
        }
    }
}