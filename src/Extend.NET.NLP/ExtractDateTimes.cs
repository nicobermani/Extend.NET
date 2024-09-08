using System.Text.RegularExpressions;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Extracts potential date and time strings from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>A list of potential date and time strings found in the text.</returns>
    public static List<string> ExtractDateTimes(this string text)
    {
        var dateTimePatterns = new[]
        {
            @"\d{1,2}/\d{1,2}/\d{2,4}",
            @"\d{1,2}-\d{1,2}-\d{2,4}",
            @"\d{4}-\d{2}-\d{2}",
            @"\d{1,2}:\d{2}(:\d{2})?(\s?[AaPp][Mm])?",
            @"\d{1,2}\s(Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec)[a-z]*\s\d{2,4}"
        };

        var combinedPattern = string.Join("|", dateTimePatterns);
        var matches = Regex.Matches(text, combinedPattern);

        var dateTimes = new List<string>();
        foreach (Match match in matches) dateTimes.Add(match.Value);

        return dateTimes;
    }
}