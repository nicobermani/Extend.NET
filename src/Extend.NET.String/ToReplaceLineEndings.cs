namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Replaces all line endings in the string with a specified line ending.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <param name="newLineEnding">The new line ending to use.</param>
        /// <returns>The string with standardized line endings.</returns>
        public static string ToReplaceLineEndings(this string @this, string newLineEnding = "\n")
        {
            return @this.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", newLineEnding);
        }
    }
}