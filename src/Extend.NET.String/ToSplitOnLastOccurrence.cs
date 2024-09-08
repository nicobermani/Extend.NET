namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Splits the string into two parts at the last occurrence of the specified separator.
        /// </summary>
        /// <param name="this">The string to split.</param>
        /// <param name="separator">The separator to split on.</param>
        /// <returns>An array containing the two parts of the split string.</returns>
        public static string[] ToSplitOnLastOccurrence(this string @this, string separator)
        {
            int separatorIndex = @this.LastIndexOf(separator);
            if (separatorIndex == -1)
                return new[] { @this };

            return new[]
            {
                @this.Substring(0, separatorIndex),
                @this.Substring(separatorIndex + separator.Length)
            };
        }
    }
}