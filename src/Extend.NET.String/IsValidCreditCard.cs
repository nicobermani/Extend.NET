namespace Extend.NET.String;

using System.Text.RegularExpressions;

public static partial class StringExtensions
{
    /// <summary>
    /// Checks if the string is a valid credit card number using the Luhn algorithm.
    /// </summary>
    /// <param name="this">The string to check.</param>
    /// <returns>True if the string is a valid credit card number; otherwise, false.</returns>
    public static bool IsValidCreditCard(this string @this)
    {
        @this = Regex.Replace(@this, @"[^\d]", "");
        if (@this.Length < 13 || @this.Length > 19)
            return false;

        var sum = 0;
        var alternate = false;
        for (var i = @this.Length - 1; i >= 0; i--)
        {
            var n = int.Parse(@this[i].ToString());
            if (alternate)
            {
                n *= 2;
                if (n > 9)
                    n = n % 10 + 1;
            }

            sum += n;
            alternate = !alternate;
        }

        return sum % 10 == 0;
    }
}