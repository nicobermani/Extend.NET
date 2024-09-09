namespace Extend.NET.Regex;

public static partial class RegexExtensions
{
    /// <summary>
    /// Determines whether the input string is a strong password.
    /// A strong password is defined as having at least 8 characters, 
    /// including at least one uppercase letter, one lowercase letter, one number, and one special character.
    /// </summary>
    /// <param name="input">The string to check.</param>
    /// <returns>True if the input is a strong password; otherwise, false.</returns>
    public static bool IsStrongPassword(this string input)
    {
        var pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
        return System.Text.RegularExpressions.Regex.IsMatch(input, pattern);
    }
}