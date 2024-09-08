namespace Extend.NET.String
{
    using System.Linq;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Reverses each word in the string while maintaining word order.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with each word reversed.</returns>
        public static string ToReverseEachWord(this string @this)
        {
            return string.Join(" ", @this.Split(' ')
                .Select(word => new string(word.Reverse().ToArray())));
        }
    }
}