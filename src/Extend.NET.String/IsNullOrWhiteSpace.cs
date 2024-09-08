namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string is null, empty, or consists only of white-space characters; otherwise, false.</returns>
        public static bool IsNullOrWhiteSpace(this string? @this)
        {
            return string.IsNullOrWhiteSpace(@this);
        }
    }
}