namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes all non-numeric characters from the string.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>A new string containing only numeric characters.</returns>
        public static string RemoveNonNumeric(this string @this)
        {
            return new string(@this.Where(char.IsDigit).ToArray());
        }
    }
}