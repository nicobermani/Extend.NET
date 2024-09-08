namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Splits a PascalCase string into separate words.
        /// </summary>
        /// <param name="this">The PascalCase string to split.</param>
        /// <returns>A string with space-separated words.</returns>
        public static string ToSplitPascalCase(this string @this)
        {
            if (string.IsNullOrEmpty(@this))
                return @this;

            return Regex.Replace(@this, "([A-Z])", " $1", RegexOptions.Compiled).Trim();
        }
    }
}