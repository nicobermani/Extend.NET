namespace Extend.NET.String;

using System;

public static partial class StringExtensions
{
    /// <summary>
    /// Shuffles the characters in the string randomly.
    /// </summary>
    /// <param name="this">The string to shuffle.</param>
    /// <returns>A new string with the characters shuffled randomly.</returns>
    public static string ToShuffle(this string @this)
    {
        var chars = @this.ToCharArray();
        var random = new Random();

        for (var i = chars.Length - 1; i > 0; i--)
        {
            var j = random.Next(i + 1);
            var temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }

        return new string(chars);
    }
}