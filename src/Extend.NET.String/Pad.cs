namespace Extend.NET.String
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Pads the string to a specified length with a specified character.
        /// </summary>
        /// <param name="this">The string to pad.</param>
        /// <param name="totalWidth">The total width of the resulting string.</param>
        /// <param name="paddingChar">The character to use for padding.</param>
        /// <param name="padLeft">If true, pad on the left; otherwise, pad on the right.</param>
        /// <returns>The padded string.</returns>
        public static string Pad(this string @this, int totalWidth, char paddingChar = ' ', bool padLeft = false)
        {
            if (@this.Length >= totalWidth)
                return @this;

            string padding = new string(paddingChar, totalWidth - @this.Length);
            return padLeft ? padding + @this : @this + padding;
        }
    }
}