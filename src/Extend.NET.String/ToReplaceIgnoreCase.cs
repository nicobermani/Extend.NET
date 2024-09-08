namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all occurrences of a specified string in the current instance with another specified string, ignoring case.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="oldValue">The string to be replaced.</param>
        /// <param name="newValue">The string to replace all occurrences of oldValue.</param>
        /// <returns>A string that is equivalent to the current string except that all instances of oldValue are replaced with newValue. The comparison is case-insensitive.</returns>
        public static string ToReplaceIgnoreCase(this string @this, string oldValue, string newValue)
        {
            return System.Text.RegularExpressions.Regex.Replace(
                @this,
                System.Text.RegularExpressions.Regex.Escape(oldValue),
                newValue.Replace("$", "$$"),
                System.Text.RegularExpressions.RegexOptions.IgnoreCase
            );
        }
    }
}