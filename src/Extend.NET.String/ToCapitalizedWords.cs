namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Capitalizes the first letter of each word in the string.
        /// </summary>
        /// <param name="this">The string to capitalize.</param>
        /// <returns>The string with the first letter of each word capitalized.</returns>
        public static string ToCapitalizedWords(this string @this)
        {
            return string.Join(" ", @this.Split(' ')
                .Select(word => word.Length > 0 
                    ? char.ToUpper(word[0]) + word.Substring(1).ToLower() 
                    : word));
        }
    }
}