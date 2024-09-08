namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Toggles the case of each character in the string.
        /// </summary>
        /// <param name="this">The string to toggle case.</param>
        /// <returns>The string with toggled case.</returns>
        public static string ToToggleCase(this string @this)
        {
            return new string(@this.Select(c => char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)).ToArray());
        }
    }
}