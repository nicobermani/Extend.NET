namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Splits the string into an array of sentences.
        /// </summary>
        /// <param name="this">The string to split into sentences.</param>
        /// <returns>An array of sentences.</returns>
        public static string[] ToSplitIntoSentences(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return new string[0];

            return Regex.Split(@this, @"(?<=[.!?])\s+")
                        .Where(s => !string.IsNullOrWhiteSpace(s))
                        .ToArray();
        }
    }
}