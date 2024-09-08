namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Checks if all characters in the string are unique.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if all characters are unique; otherwise, false.</returns>
        public static bool ToIsAllUnique(this string @this)
        {
            return @this.Distinct().Count() == @this.Length;
        }
    }
}