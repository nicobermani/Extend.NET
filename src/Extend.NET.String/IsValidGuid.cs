namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Determines whether the string is a valid GUID.
        /// </summary>
        /// <param name="this">The string to check.</param>
        /// <returns>True if the string is a valid GUID; otherwise, false.</returns>
        public static bool IsValidGuid(this string @this)
        {
            return Guid.TryParse(@this, out _);
        }
    }
}