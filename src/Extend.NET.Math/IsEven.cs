namespace Extend.NET.Math;

public static partial class MathExtensions
{
    /// <summary>
    /// Determines whether the specified integer is even.
    /// </summary>
    /// <param name="number">The number to check.</param>
    /// <returns>True if the number is even; otherwise, false.</returns>
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
}