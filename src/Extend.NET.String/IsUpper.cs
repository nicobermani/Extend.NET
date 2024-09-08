namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether all characters in the string are uppercase.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if all characters are uppercase; otherwise, false.</returns>
        public static bool IsUpper(this string @this)
        {
            return !string.IsNullOrEmpty(@this) && @this.All(char.IsUpper);
        }
    }
}