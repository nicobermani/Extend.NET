namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Counts the number of distinct characters in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The number of distinct characters in the string.</returns>
        public static int ToCountDistinctCharacters(this string @this)
        {
            return @this.Distinct().Count();
        }
    }
}