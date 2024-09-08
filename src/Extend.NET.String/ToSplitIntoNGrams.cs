namespace Extend.NET.String
{
    using System.Collections.Generic;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Splits the string into n-grams of the specified size.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="n">The size of each n-gram.</param>
        /// <returns>An array of n-grams.</returns>
        public static string[] ToSplitIntoNGrams(this string @this, int n)
        {
            if (string.IsNullOrEmpty(@this) || n <= 0 || n > @this.Length)
                return new string[] { @this };

            List<string> ngrams = new List<string>();
            for (int i = 0; i <= @this.Length - n; i++)
            {
                ngrams.Add(@this.Substring(i, n));
            }

            return ngrams.ToArray();
        }
    }
}