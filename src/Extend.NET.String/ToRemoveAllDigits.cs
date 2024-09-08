namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all digits from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with all digits removed.</returns>
        public static string ToRemoveAllDigits(this string @this)
        {
            return new string(@this.Where(c => !char.IsDigit(c)).ToArray());
        }
    }
}