namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Removes the specified suffix from the string if it exists.
        /// </summary>
        /// <param name="this">The string to remove the suffix from.</param>
        /// <param name="suffix">The suffix to remove.</param>
        /// <returns>The string with the suffix removed if it existed; otherwise, the original string.</returns>
        public static string RemoveSuffix(this string @this, string suffix)
        {
            return @this.EndsWith(suffix) ? @this.Substring(0, @this.Length - suffix.Length) : @this;
        }
    }
}