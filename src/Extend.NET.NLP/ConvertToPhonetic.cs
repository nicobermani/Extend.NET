using System.Text;

namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Converts the input text to its phonetic representation using a simplified Soundex algorithm.
    /// </summary>
    /// <param name="text">The input text to convert.</param>
    /// <returns>The phonetic representation of the input text.</returns>
    public static string ConvertToPhonetic(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;

        var result = new StringBuilder();
        result.Append(char.ToUpper(text[0]));

        for (var i = 1; i < text.Length; i++)
        {
            var c = char.ToUpper(text[i]);
            switch (c)
            {
                case 'B':
                case 'F':
                case 'P':
                case 'V':
                    result.Append('1');
                    break;
                case 'C':
                case 'G':
                case 'J':
                case 'K':
                case 'Q':
                case 'S':
                case 'X':
                case 'Z':
                    result.Append('2');
                    break;
                case 'D':
                case 'T':
                    result.Append('3');
                    break;
                case 'L':
                    result.Append('4');
                    break;
                case 'M':
                case 'N':
                    result.Append('5');
                    break;
                case 'R':
                    result.Append('6');
                    break;
            }
        }

        return result.ToString().PadRight(4, '0').Substring(0, 4);
    }
}