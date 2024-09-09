namespace Extend.NET.Regex
{
    public static partial class RegexExtensions
    {
        /// <summary>
        /// Replaces characters in the input string with a mask character, based on a regular expression pattern.
        /// </summary>
        /// <param name="input">The input string to mask.</param>
        /// <param name="pattern">The regular expression pattern to match.</param>
        /// <param name="maskChar">The character to use for masking. Default is '*'.</param>
        /// <returns>A new string with matched portions replaced by the mask character.</returns>
        public static string ReplaceWithMask(this string input, string pattern, char maskChar = '*')
        {
            return System.Text.RegularExpressions.Regex.Replace(input, pattern, match => new string(maskChar, match.Length));
        }
    }
}