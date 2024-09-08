namespace Extend.NET.String;

public static partial class StringExtensions
{
    /// <summary>
    /// Rotates the string by a specified number of positions.
    /// </summary>
    /// <param name="this">The string to rotate.</param>
    /// <param name="positions">The number of positions to rotate. Positive for right rotation, negative for left.</param>
    /// <returns>The rotated string.</returns>
    public static string ToRotate(this string @this, int positions)
    {
        if (string.IsNullOrEmpty(@this) || positions == 0)
            return @this;

        var actualPositions = positions % @this.Length;
        if (actualPositions < 0)
            actualPositions += @this.Length;

        return @this.Substring(@this.Length - actualPositions) + @this.Substring(0, @this.Length - actualPositions);
    }
}