namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Replaces newline characters in the input string with HTML line break tags.
        /// </summary>
        /// <param name="input">The string to process.</param>
        /// <returns>A new string with newlines replaced by HTML line break tags.</returns>
        public static string ReplaceNewlinesWithHtmlBreaks(this string input)
        {
            return System.Text.RegularExpressions.Regex.Replace(input, @"\r\n?|\n", "<br />");
        }
    }
}