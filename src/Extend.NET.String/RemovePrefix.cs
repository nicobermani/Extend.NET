namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes the specified prefix from the string if it exists.
        /// </summary>
        /// <param name="this">The string to remove the prefix from.</param>
        /// <param name="prefix">The prefix to remove.</param>
        /// <returns>The string with the prefix removed if it existed; otherwise, the original string.</returns>
        public static string RemovePrefix(this string @this, string prefix)
        {
            return @this.StartsWith(prefix) ? @this.Substring(prefix.Length) : @this;
        }
    }
}