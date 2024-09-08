using System;
using System.Text.RegularExpressions;

public static partial class NlpExtensions
{
    /// <summary>
    /// Converts the input text to snake_case.
    /// </summary>
    /// <param name="text">The input text to convert.</param>
    /// <returns>The text converted to snake_case.</returns>
    public static string ConvertToSnakeCase(this string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        var snakeCase = Regex.Replace(text, @"([a-z0-9])([A-Z])", "$1_$2");
        snakeCase = Regex.Replace(snakeCase, @"([A-Z])([A-Z][a-z])", "$1_$2");
        snakeCase = Regex.Replace(snakeCase, @"[-\s]", "_");
        return snakeCase.ToLower();
    }
}