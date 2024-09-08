namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the string contains only alphabetic characters.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string contains only alphabetic characters; otherwise, false.</returns>
        public static bool IsAlphabetic(this string @this)
        {
            return !string.IsNullOrWhiteSpace(@this) && @this.All(char.IsLetter);
        }
    }
}