namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the singular form of a word to its plural form.
        /// </summary>
        /// <param name="this">The singular word to convert.</param>
        /// <returns>The plural form of the word.</returns>
        public static string ToPlural(this string @this)
        {
            if (string.IsNullOrEmpty(@this)) return @this;

            if (@this.EndsWith("y", StringComparison.OrdinalIgnoreCase))
                return @this.Substring(0, @this.Length - 1) + "ies";
            else if (@this.EndsWith("s", StringComparison.OrdinalIgnoreCase) ||
                     @this.EndsWith("ch", StringComparison.OrdinalIgnoreCase) ||
                     @this.EndsWith("sh", StringComparison.OrdinalIgnoreCase) ||
                     @this.EndsWith("x", StringComparison.OrdinalIgnoreCase))
                return @this + "es";
            else
                return @this + "s";
        }
    }
}