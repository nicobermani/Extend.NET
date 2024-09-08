namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the string can be parsed as a valid DateTime.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string can be parsed as a valid DateTime; otherwise, false.</returns>
        public static bool IsValidDateTime(this string @this)
        {
            return DateTime.TryParse(@this, out _);
        }
    }
}