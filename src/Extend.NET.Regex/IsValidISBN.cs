namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid ISBN (International Standard Book Number).
    /// Supports both ISBN-10 and ISBN-13 formats, with or without hyphens.
    /// </summary>
    /// <param name="input">The input string to validate as an ISBN.</param>
    /// <returns>True if the input is a valid ISBN; otherwise, false.</returns>
    public static bool IsValidISBN(this string input)
    {
        var regex = new System.Text.RegularExpressions.Regex(
            @"^(?:ISBN(?:-1[03])?:? )?(?=[0-9X]{10}$|(?=(?:[0-9]+[- ]){3})[- 0-9X]{13}$|97[89][0-9]{10}$|(?=(?:[0-9]+[- ]){4})[- 0-9]{17}$)(?:97[89][- ]?)?[0-9]{1,5}[- ]?[0-9]+[- ]?[0-9]+[- ]?[0-9X]$");
        return regex.IsMatch(input);
    }
}