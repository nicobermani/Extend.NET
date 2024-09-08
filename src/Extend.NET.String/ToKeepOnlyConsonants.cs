namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Keeps only the consonants in the string, removing all other characters.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string containing only the consonants from the original string.</returns>
        public static string ToKeepOnlyConsonants(this string @this)
        {
            return new string(@this.Where(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c)).ToArray());
        }
    }
}