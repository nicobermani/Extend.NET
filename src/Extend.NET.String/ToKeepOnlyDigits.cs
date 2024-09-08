namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Keeps only the digits in the string, removing all other characters.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string containing only the digits from the original string.</returns>
        public static string ToKeepOnlyDigits(this string @this)
        {
            return new string(@this.Where(char.IsDigit).ToArray());
        }
    }
}