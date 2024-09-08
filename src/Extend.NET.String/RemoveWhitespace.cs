namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all whitespace characters from the string.
        /// </summary>
        /// <param name="this">The string to remove whitespace from.</param>
        /// <returns>A new string with all whitespace removed.</returns>
        public static string RemoveWhitespace(this string @this)
        {
            return new string(@this.Where(c => !char.IsWhiteSpace(c)).ToArray());
        }
    }
}