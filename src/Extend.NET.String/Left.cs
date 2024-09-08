namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Returns a string containing a specified number of characters from the left side of a string.
        /// </summary>
        /// <param name="this">The string to retrieve characters from.</param>
        /// <param name="length">The number of characters to retrieve.</param>
        /// <returns>The left part of the string.</returns>
        public static string Left(this string @this, int length)
        {
            if (string.IsNullOrEmpty(@this)) return string.Empty;
            length = Math.Abs(length);
            return (@this.Length <= length) ? @this : @this.Substring(0, length);
        }
    }
}