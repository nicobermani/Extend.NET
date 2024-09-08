namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces every nth word in the string with a specified replacement.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="n">The interval at which to replace words.</param>
        /// <param name="replacement">The string to replace the words with.</param>
        /// <returns>A new string with every nth word replaced.</returns>
        public static string ToReplaceEveryNthWord(this string @this, int n, string replacement)
        {
            if (string.IsNullOrWhiteSpace(@this) || n <= 0)
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Select((word, index) => (index + 1) % n == 0 ? replacement : word));
        }
    }
}