using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Finds potential named entities in the input text using simple heuristics.
    /// </summary>
    /// <param name="text">The input text to analyze.</param>
    /// <returns>A list of potential named entities.</returns>
    public static List<string> FindNamedEntities(this string text)
    {
        var entities = new List<string>();
        var words = text.Split();
        var capitalizedWordPattern = new Regex(@"^[A-Z][a-z]+$");

        for (int i = 0; i < words.Length; i++)
        {
            if (capitalizedWordPattern.IsMatch(words[i]))
            {
                var entity = words[i];
                while (i + 1 < words.Length && capitalizedWordPattern.IsMatch(words[i + 1]))
                {
                    entity += " " + words[i + 1];
                    i++;
                }
                entities.Add(entity);
            }
        }

        return entities;
    }
}