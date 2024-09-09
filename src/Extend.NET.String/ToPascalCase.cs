namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to PascalCase.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The string converted to PascalCase.</returns>
        public static string ToPascalCase(this string @this)
        {
            var words = @this.Split(new[] {'_', ' ', '-'}, StringSplitOptions.RemoveEmptyEntries);
            return string.Join("", words.Select(word => char.ToUpper(word[0]) + word.Substring(1).ToLower()));
        }
    }
}