using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public static partial class NlpExtensions
{
    /// <summary>
    /// Extracts email addresses from the input text.
    /// </summary>
    /// <param name="text">The input text to process.</param>
    /// <returns>A list of email addresses found in the text.</returns>
    public static List<string> ExtractEmailAddresses(this string text)
    {
        var emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        var matches = Regex.Matches(text, emailPattern);
        
        var emailAddresses = new List<string>();
        foreach (Match match in matches)
        {
            emailAddresses.Add(match.Value);
        }

        return emailAddresses;
    }
}