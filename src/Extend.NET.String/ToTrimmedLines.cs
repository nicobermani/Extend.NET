namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Splits the string into trimmed lines, removing empty lines.
        /// </summary>
        /// <param name="this">The string to split into lines.</param>
        /// <returns>An array of trimmed, non-empty lines.</returns>
        public static string[] ToTrimmedLines(this string @this)
        {
            return @this.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(s => s.Trim())
                        .Where(s => !string.IsNullOrEmpty(s))
                        .ToArray();
        }
    }
}