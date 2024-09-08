namespace Extend.NET.String;

public static partial class StringExtensions
{
    /// <summary>
    /// Determines whether the string contains all of the specified substrings.
    /// </summary>
    /// <param name="this">The string to search in.</param>
    /// <param name="values">The substrings to search for.</param>
    /// <returns>True if the string contains all of the specified substrings; otherwise, false.</returns>
    public static bool ContainsAll(this string @this, params string[] values)
    {
        foreach (var value in values)
            if (!@this.Contains(value))
                return false;
        return true;
    }
}