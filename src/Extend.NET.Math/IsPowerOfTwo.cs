namespace Extend.NET.Math;

public static partial class MathExtensions
{
    /// <summary>
    /// Determines whether the specified number is a power of two.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>True if the number is a power of two; otherwise, false.</returns>
    public static bool IsPowerOfTwo(this int number)
    {
        return number > 0 && (number & (number - 1)) == 0;
    }
}