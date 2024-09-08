namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the first character of the string to lowercase.
        /// </summary>
        /// <param name="this">The string to process.</param>
        /// <returns>The string with the first character in lowercase.</returns>
        public static string ToFirstCharacterLowerCase(this string @this)
        {
            if (string.IsNullOrEmpty(@this) || char.IsLower(@this[0]))
                return @this;

            return char.ToLower(@this[0]) + @this.Substring(1);
        }
    }
}