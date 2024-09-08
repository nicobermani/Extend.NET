namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Reverses the order of words in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string with the words in reverse order.</returns>
        public static string ToReverseWords(this string @this)
        {
            if (string.IsNullOrWhiteSpace(@this))
                return @this;

            return string.Join(" ", @this.Split(' ').Reverse());
        }
    }
}