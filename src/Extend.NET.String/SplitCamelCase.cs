namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Splits a camelCase or PascalCase string into separate words.
        /// </summary>
        /// <param name="this">The string to split.</param>
        /// <returns>A string with space-separated words.</returns>
        public static string SplitCamelCase(this string @this)
        {
            return Regex.Replace(@this, "([A-Z])", " $1", RegexOptions.Compiled).Trim();
        }
    }
}