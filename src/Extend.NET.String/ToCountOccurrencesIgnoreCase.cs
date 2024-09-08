namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Counts the number of occurrences of a substring within the string, ignoring case.
        /// </summary>
        /// <param name="this">The string to search in.</param>
        /// <param name="substring">The substring to search for.</param>
        /// <returns>The number of occurrences of the substring.</returns>
        public static int ToCountOccurrencesIgnoreCase(this string @this, string substring)
        {
            if (string.IsNullOrEmpty(@this) || string.IsNullOrEmpty(substring))
                return 0;

            return @this.ToLower().Split(new[] { substring.ToLower() }, StringSplitOptions.None).Length - 1;
        }
    }
}