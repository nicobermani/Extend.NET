namespace Extend.NET.String
{
    using System.Collections.Generic;
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Calculates the frequency of each word in the string.
        /// </summary>
        /// <param name="this">The string to analyze.</param>
        /// <returns>A dictionary with words as keys and their frequencies as values.</returns>
        public static Dictionary<string, int> ToWordFrequency(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return new Dictionary<string, int>();

            return @this.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                        .GroupBy(word => word.ToLower())
                        .ToDictionary(group => group.Key, group => group.Count());
        }
    }
}