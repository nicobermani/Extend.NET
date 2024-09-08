namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Returns the last character of the string.
        /// </summary>
        /// <param name="this">The string to get the last character from.</param>
        /// <returns>The last character of the string, or null if the string is empty.</returns>
        public static char? LastCharacter(this string @this)
        {
            return @this.Length > 0 ? @this[@this.Length - 1] : (char?)null;
        }
    }
}