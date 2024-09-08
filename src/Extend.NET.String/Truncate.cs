namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Truncates the string to a specified length and adds an ellipsis (...) if it exceeds that length.
        /// </summary>
        /// <param name="this">The string to truncate.</param>
        /// <param name="maxLength">The maximum length of the string.</param>
        /// <returns>The truncated string with ellipsis if necessary.</returns>
        public static string Truncate(this string @this, int maxLength)
        {
            const string ellipsis = "...";
            return @this.Length <= maxLength ? @this : @this.Substring(0, maxLength - ellipsis.Length) + ellipsis;
        }
    }
}