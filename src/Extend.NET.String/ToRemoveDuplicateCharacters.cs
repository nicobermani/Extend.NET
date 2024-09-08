namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes duplicate characters from the string, keeping only the first occurrence of each character.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with duplicate characters removed.</returns>
        public static string ToRemoveDuplicateCharacters(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
                return @this;

            return new string(@this.Distinct().ToArray());
        }
    }
}