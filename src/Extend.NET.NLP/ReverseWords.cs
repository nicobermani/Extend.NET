namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Reverses the order of words in the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>The text with words in reverse order.</returns>
    public static string ReverseWords(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        var words = text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        return string.Join(" ", words.Reverse());
    }
}