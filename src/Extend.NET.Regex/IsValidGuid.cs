namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid GUID.
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if the input is a valid GUID; otherwise, false.</returns>
    public static bool IsValidGuid(this string input)
    {
        var pattern = @"^[{]?[0-9a-fA-F]{8}-([0-9a-fA-F]{4}-){3}[0-9a-fA-F]{12}[}]?$";
        return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
    }
}