namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to kebab-case.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The string converted to kebab-case.</returns>
        public static string ToKebabCase(this string @this)
        {
            if (string.IsNullOrEmpty(@this)) return @this;

            return Regex.Replace(@this, "([a-z])([A-Z])", "$1-$2").ToLower();
        }
    }
}