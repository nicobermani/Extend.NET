namespace Extend.NET.String;

public static partial class StringExtensions
{
    /// <summary>
    /// Replaces the last occurrence of a specified string with another string.
    /// </summary>
    /// <param name="this">The string to process.</param>
    /// <param name="oldValue">The string to be replaced.</param>
    /// <param name="newValue">The string to replace the last occurrence of oldValue.</param>
    /// <returns>A new string with the last occurrence of oldValue replaced by newValue.</returns>
    public static string ToReplaceLastOccurrence(this string @this, string oldValue, string newValue)
    {
        var index = @this.LastIndexOf(oldValue);
        if (index == -1)
            return @this;

        return @this.Remove(index, oldValue.Length).Insert(index, newValue);
    }
}