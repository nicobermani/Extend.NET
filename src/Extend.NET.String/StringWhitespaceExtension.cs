namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all whitespace characters from the string.
        /// </summary>
        /// <param name="str">The string to remove whitespace from.</param>
        /// <returns>The string with all whitespace removed.</returns>
        public static string RemoveWhitespace(this string str)
        {
            return string.Concat(str.Where(c => !char.IsWhiteSpace(c)));
        }
    }
}