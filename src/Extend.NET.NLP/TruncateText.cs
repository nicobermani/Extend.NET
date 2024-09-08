namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Truncates the input text to a specified length, ensuring it doesn't cut off in the middle of a word.
    /// </summary>
    /// <param name="text">The input text to truncate.</param>
    /// <param name="maxLength">The maximum length of the truncated text.</param>
    /// <param name="appendEllipsis">Whether to append an ellipsis (...) to the truncated text.</param>
    /// <returns>The truncated text.</returns>
    public static string TruncateText(this string text, int maxLength, bool appendEllipsis = true)
    {
        if (string.IsNullOrEmpty(text) || text.Length <= maxLength)
            return text;

        var truncated = text.Substring(0, maxLength);
        var lastSpaceIndex = truncated.LastIndexOf(' ');

        if (lastSpaceIndex > 0) truncated = truncated.Substring(0, lastSpaceIndex);

        if (appendEllipsis) truncated += "...";

        return truncated;
    }
}