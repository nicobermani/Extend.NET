namespace Extend.NET.Math;

public static partial class MathExtensions
{
    /// <summary>
    /// Calculates the factorial of the specified number.
    /// </summary>
    /// <param name="number">The number to calculate the factorial for.</param>
    /// <returns>The factorial of the number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the number is negative.</exception>
    public static long Factorial(this int number)
    {
        if (number < 0)
            throw new ArgumentOutOfRangeException(nameof(number), "Factorial is not defined for negative numbers.");

        if (number <= 1)
            return 1;

        return number * Factorial(number - 1);
    }
}