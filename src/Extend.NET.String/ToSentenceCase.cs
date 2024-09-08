namespace Extend.NET.String
{
    using System.Text.RegularExpressions;

    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to sentence case.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <returns>The string converted to sentence case.</returns>
        public static string ToSentenceCase(this string @this)
        {
            if (string.IsNullOrEmpty(@this)) return @this;
            return Regex.Replace(@this, @"(^\w)|[\.\!\?]\s+(\w)", m => m.Value.ToUpper());
        }
    }
}