namespace Extend.NET.String;

using System.Text;

public static partial class StringExtensions
{
    /// <summary>
    /// Wraps words in the string to ensure that no line exceeds the specified width.
    /// </summary>
    /// <param name="this">The string to word wrap.</param>
    /// <param name="width">The maximum width of each line.</param>
    /// <returns>The word-wrapped string.</returns>
    public static string ToWordWrap(this string @this, int width)
    {
        int pos, next;
        var sb = new StringBuilder();

        for (pos = 0; pos < @this.Length; pos = next)
        {
            var endLine = pos + width;
            if (endLine <= @this.Length)
            {
                next = @this.LastIndexOf(' ', endLine);
                if (next <= pos) next = @this.IndexOf(' ', endLine);
            }
            else
            {
                next = @this.Length;
            }

            if (next <= pos) next = @this.Length;

            sb.AppendLine(@this.Substring(pos, next - pos).Trim());
        }

        return sb.ToString();
    }
}