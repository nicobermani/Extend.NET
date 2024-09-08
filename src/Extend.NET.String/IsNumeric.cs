namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the string contains only numeric characters.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string contains only numeric characters; otherwise, false.</returns>
        public static bool IsNumeric(this string @this)
        {
            return !string.IsNullOrWhiteSpace(@this) && @this.All(char.IsDigit);
        }
    }
}