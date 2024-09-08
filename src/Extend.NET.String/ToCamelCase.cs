namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to camelCase.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The string converted to camelCase.</returns>
        public static string ToCamelCase(this string @this)
        {
            if (string.IsNullOrEmpty(@this)) return @this;
            return char.ToLowerInvariant(@this[0]) + @this.Substring(1);
        }
    }
}