namespace Extend.NET.String;

public static partial class StringExtensions
{
    /// <summary>
    /// Replaces occurrences of a string with another string, preserving the case of the original.
    /// </summary>
    /// <param name="this">The string to process.</param>
    /// <param name="oldValue">The string to be replaced.</param>
    /// <param name="newValue">The string to replace all occurrences of oldValue.</param>
    /// <returns>The string with replacements made while preserving case.</returns>
    public static string ToReplaceWithCase(this string @this, string oldValue, string newValue)
    {
        var index = @this.IndexOf(oldValue, StringComparison.OrdinalIgnoreCase);
        if (index < 0)
            return @this;

        var result = @this;
        while (index >= 0)
        {
            var replacement = PreserveCase(@this.Substring(index, oldValue.Length), newValue);
            result = result.Remove(index, oldValue.Length).Insert(index, replacement);
            index = result.IndexOf(oldValue, index + replacement.Length, StringComparison.OrdinalIgnoreCase);
        }

        return result;
    }

    private static string PreserveCase(string original, string replacement)
    {
        if (string.IsNullOrEmpty(original))
            return replacement;

        var result = replacement.ToCharArray();

        for (var i = 0; i < result.Length && i < original.Length; i++)
            if (char.IsUpper(original[i]))
                result[i] = char.ToUpper(result[i]);
            else if (char.IsLower(original[i]))
                result[i] = char.ToLower(result[i]);

        return new string(result);
    }
}