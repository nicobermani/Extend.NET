namespace Extend.NET.String;

public static partial class StringExtensions
{
    /// <summary>
    /// Centers the string within a specified total width.
    /// </summary>
    /// <param name="this">The string to center.</param>
    /// <param name="totalWidth">The total width of the resulting string.</param>
    /// <param name="paddingChar">The character to use for padding.</param>
    /// <returns>The centered string.</returns>
    public static string Center(this string @this, int totalWidth, char paddingChar = ' ')
    {
        if (@this.Length >= totalWidth)
            return @this;

        var padding = totalWidth - @this.Length;
        var padLeft = padding / 2 + @this.Length;
        return @this.PadLeft(padLeft, paddingChar).PadRight(totalWidth, paddingChar);
    }
}