namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Trims the start of the string and ensures it doesn't exceed a maximum length.
        /// </summary>
        /// <param name="this">The string to trim.</param>
        /// <param name="maxLength">The maximum length of the resulting string.</param>
        /// <returns>The trimmed string.</returns>
        public static string ToTrimmedStart(this string @this, int maxLength)
        {
            if (string.IsNullOrEmpty(@this) || maxLength <= 0)
                return string.Empty;

            if (@this.Length <= maxLength)
                return @this.TrimStart();

            return @this.Substring(@this.Length - maxLength).TrimStart();
        }
    }
}