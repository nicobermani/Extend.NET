namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Truncates the string to a specified length and adds an ellipsis if truncated.
        /// </summary>
        /// <param name="this">The string to truncate.</param>
        /// <param name="maxLength">The maximum length of the resulting string, including the ellipsis if added.</param>
        /// <param name="ellipsis">The string to add at the end if truncated. Default is "...".</param>
        /// <returns>The truncated string.</returns>
        public static string ToTruncatedString(this string @this, int maxLength, string ellipsis = "...")
        {
            if (@this.Length <= maxLength)
                return @this;

            int truncatedLength = maxLength - ellipsis.Length;
            return @this.Substring(0, truncatedLength) + ellipsis;
        }
    }
}