namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid hexadecimal color code.
    /// Supports formats: #RGB, #RRGGBB
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if the input is a valid hexadecimal color code; otherwise, false.</returns>
    public static bool IsValidHexColor(this string input)
    {
        var pattern = @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";
        return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
    }
}