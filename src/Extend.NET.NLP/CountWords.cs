namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Counts the number of words in the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>The number of words in the text.</returns>
    public static int CountWords(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return 0;

        return text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}