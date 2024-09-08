namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Swaps the case of each character in the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with swapped case.</returns>
        public static string ToSwapCase(this string @this)
        {
            return new string(@this.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray());
        }
    }
}