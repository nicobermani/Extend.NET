namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Truncates the string to a specified length and adds an ellipsis if truncated.
        /// </summary>
        /// <param name="str">The string to truncate.</param>
        /// <param name="maxLength">The maximum length of the string.</param>
        /// <param name="ellipsis">The string to append if truncated. Default is "...".</param>
        /// <returns>The truncated string.</returns>
        public static string Truncate(this string str, int maxLength, string ellipsis = "...")
        {
            if (string.IsNullOrEmpty(str) || str.Length <= maxLength)
                return str;

            return str.Substring(0, maxLength - ellipsis.Length) + ellipsis;
        }
    }
}