namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the specified string is null or empty.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string is null or empty; otherwise, false.</returns>
        public static bool IsNullOrEmpty(this string? @this)
        {
            return string.IsNullOrEmpty(@this);
        }
    }
}