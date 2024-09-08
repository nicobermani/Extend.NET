namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Reverses the order of words in the string while maintaining the order of characters within each word.
        /// </summary>
        /// <param name="this">The string to reverse words in.</param>
        /// <returns>A string with the words in reverse order.</returns>
        public static string ToReverseWords(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
                return @this;

            string[] words = @this.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
    }
}