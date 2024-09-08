namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the plural form of a word to its singular form.
        /// </summary>
        /// <param name="this">The plural word to convert.</param>
        /// <returns>The singular form of the word.</returns>
        public static string ToSingular(this string @this)
        {
            if (string.IsNullOrEmpty(@this)) return @this;

            if (@this.EndsWith("ies", StringComparison.OrdinalIgnoreCase))
                return @this.Substring(0, @this.Length - 3) + "y";
            else if (@this.EndsWith("es", StringComparison.OrdinalIgnoreCase))
                return @this.Substring(0, @this.Length - 2);
            else if (@this.EndsWith("s", StringComparison.OrdinalIgnoreCase))
                return @this.Substring(0, @this.Length - 1);
            else
                return @this;
        }
    }
}