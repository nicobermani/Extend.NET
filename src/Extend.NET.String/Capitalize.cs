namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Capitalizes the first character of the string.
        /// </summary>
        /// <param name="this">The string to capitalize.</param>
        /// <returns>The string with the first character capitalized.</returns>
        public static string Capitalize(this string @this)
        {
            if (string.IsNullOrEmpty(@this)) return @this;
            return char.ToUpper(@this[0]) + @this.Substring(1);
        }
    }
}