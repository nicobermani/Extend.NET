namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Splits the string into an array of words.
        /// </summary>
        /// <param name="this">The string to split into words.</param>
        /// <returns>An array of words from the string.</returns>
        public static string[] ToWordArray(this string @this)
        {
            return @this.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}