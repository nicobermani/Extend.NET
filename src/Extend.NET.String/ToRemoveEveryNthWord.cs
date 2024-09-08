namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes every nth word from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="n">The interval at which to remove words.</param>
        /// <returns>A new string with every nth word removed.</returns>
        public static string ToRemoveEveryNthWord(this string @this, int n)
        {
            if (string.IsNullOrWhiteSpace(@this) || n <= 1)
                return @this;

            return string.Join(" ", @this.Split(' ')
                .Where((word, index) => (index + 1) % n != 0));
        }
    }
}