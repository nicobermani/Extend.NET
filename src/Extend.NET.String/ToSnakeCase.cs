namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to snake_case.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The string converted to snake_case.</returns>
        public static string ToSnakeCase(this string @this)
        {
            return string.Concat(@this.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();
        }
    }
}