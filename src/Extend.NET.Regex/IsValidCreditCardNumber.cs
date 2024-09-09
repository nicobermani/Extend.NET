namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a valid credit card number.
    /// Supports major credit card formats (Visa, MasterCard, American Express, Discover).
    /// </summary>
    /// <param name="input">The input string to validate as a credit card number.</param>
    /// <returns>True if the input is a valid credit card number; otherwise, false.</returns>
    public static bool IsValidCreditCardNumber(this string input)
    {
        var regex = new System.Text.RegularExpressions.Regex(
            @"^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|3[47][0-9]{13}|6(?:011|5[0-9][0-9])[0-9]{12})$");
        return regex.IsMatch(input.Replace(" ", "").Replace("-", ""));
    }
}