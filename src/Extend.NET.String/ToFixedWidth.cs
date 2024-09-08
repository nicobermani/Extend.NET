namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Converts the string to a fixed width by truncating or padding as necessary.
        /// </summary>
        /// <param name="this">The string to convert.</param>
        /// <param name="width">The desired width of the string.</param>
        /// <param name="padChar">The character to use for padding if necessary.</param>
        /// <returns>The string converted to the specified fixed width.</returns>
        public static string ToFixedWidth(this string @this, int width, char padChar = ' ')
        {
            if (@this.Length > width)
                return @this.Substring(0, width);
            else if (@this.Length < width)
                return @this.PadRight(width, padChar);
            else
                return @this;
        }
    }
}