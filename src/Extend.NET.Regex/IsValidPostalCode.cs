namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid postal code.
    /// Supports US ZIP codes (5 digits or 5+4 format) and Canadian postal codes.
    /// </summary>
    /// <param name="input">The input string to validate.</param>
    /// <returns>True if the input is a valid postal code; otherwise, false.</returns>
    public static bool IsValidPostalCode(this string input)
    {
        var regex = new System.Text.RegularExpressions.Regex(@"^(\d{5}(-\d{4})?|[A-Za-z]\d[A-Za-z][ -]?\d[A-Za-z]\d)$");
        return regex.IsMatch(input);
    }
}