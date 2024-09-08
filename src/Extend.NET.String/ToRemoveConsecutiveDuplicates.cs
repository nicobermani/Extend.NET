using System.Text;

namespace Extend.NET.String;

public static partial class StringExtensions
{
    /// <summary>
    /// Removes consecutive duplicate characters from the string.
    /// </summary>
    /// <param name="this">The string to process.</param>
    /// <returns>The string with consecutive duplicates removed.</returns>
    public static string ToRemoveConsecutiveDuplicates(this string @this)
    {
        if (string.IsNullOrEmpty(@this))
            return @this;

        var sb = new StringBuilder();
        sb.Append(@this[0]);

        for (var i = 1; i < @this.Length; i++)
            if (@this[i] != @this[i - 1])
                sb.Append(@this[i]);

        return sb.ToString();
    }
}