namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Counts the number of sentences in the string.
        /// </summary>
        /// <param name="this">The string to count sentences in.</param>
        /// <returns>The number of sentences in the string.</returns>
        public static int ToCountSentences(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return 0;

            return Regex.Matches(@this, @"[.!?]+").Count;
        }
    }
}