namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Converts a camelCase or PascalCase string to snake_case.
    /// </summary>
    /// <param name="input">The camelCase or PascalCase string to convert.</param>
    /// <returns>A string in snake_case format.</returns>
    public static string ConvertToSnakeCase(this string input)
    {
        return System.Text.RegularExpressions.Regex.Replace(input, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
    }
}