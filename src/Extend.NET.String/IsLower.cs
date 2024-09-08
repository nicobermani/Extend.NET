namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether all characters in the string are lowercase.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if all characters are lowercase; otherwise, false.</returns>
        public static bool IsLower(this string @this)
        {
            return !string.IsNullOrEmpty(@this) && @this.All(char.IsLower);
        }
    }
}