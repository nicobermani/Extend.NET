namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Converts a string to camelCase.
    /// </summary>
    /// <param name="input">The string to convert.</param>
    /// <returns>A string in camelCase format.</returns>
    public static string ConvertToCamelCase(this string input)
    {
        input = System.Text.RegularExpressions.Regex.Replace(input, @"[^a-zA-Z0-9]+", " ");
        if (string.IsNullOrEmpty(input))
            return input;

        var words = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        var result = words[0].ToLower();
        for (var i = 1; i < words.Length; i++) result += char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();

        return result;
    }
}