namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Reverses the order of words in each sentence of the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with words reversed in each sentence.</returns>
        public static string ToReverseWordsInSentences(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return @this;

            return string.Join(". ", @this.Split('.')
                .Select(sentence => string.Join(" ", sentence.Trim().Split(' ').Reverse()))
                .Select(sentence => char.ToUpper(sentence[0]) + sentence.Substring(1)));
        }
    }
}