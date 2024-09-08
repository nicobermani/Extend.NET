namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the string contains only alphanumeric characters.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string contains only alphanumeric characters; otherwise, false.</returns>
        public static bool IsAlphanumeric(this string @this)
        {
            return !string.IsNullOrWhiteSpace(@this) && @this.All(char.IsLetterOrDigit);
        }
    }
}