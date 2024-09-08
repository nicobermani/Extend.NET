namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Reverses the order of words in the string.
        /// </summary>
        /// <param name="this">The string to reverse words in.</param>
        /// <returns>A string with the words in reverse order.</returns>
        public static string ToReversedWords(this string @this)
        {
            return string.Join(" ", @this.Split(' ').Reverse());
        }
    }
}