namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all special characters from the string, leaving only letters and numbers.
        /// </summary>
        /// <param name="this">The string to remove special characters from.</param>
        /// <returns>A new string with only letters and numbers.</returns>
        public static string RemoveSpecialCharacters(this string @this)
        {
            return new string(@this.Where(c => char.IsLetterOrDigit(c)).ToArray());
        }
    }
}