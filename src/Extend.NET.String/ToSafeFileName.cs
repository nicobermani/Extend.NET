namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to a safe file name by removing invalid characters.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <param name="replacement">The character to use as a replacement for invalid characters.</param>
        /// <returns>A string that can be safely used as a file name.</returns>
        public static string ToSafeFileName(this string @this, string replacement = "_")
        {
            var invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var regex = new Regex($"[{Regex.Escape(invalid)}]");
            return regex.Replace(@this, replacement);
        }
    }
}