namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Counts the number of words in the string.
        /// </summary>
        /// <param name="this">The string to count words in.</param>
        /// <returns>The number of words in the string.</returns>
        public static int ToWordCount(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return 0;

            return Regex.Matches(@this, @"\b\w+\b").Count;
        }
    }
}