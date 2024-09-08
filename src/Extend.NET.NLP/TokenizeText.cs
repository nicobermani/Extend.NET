namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Tokenizes the input text into individual words.
    /// </summary>
    /// <param name="text">The input text to tokenize.</param>
    /// <returns>An array of tokens (words).</returns>
    public static string[] TokenizeText(this string text)
    {
        return text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    }
}