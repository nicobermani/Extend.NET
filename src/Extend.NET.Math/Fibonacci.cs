namespace Extend.NET.Math;

public static partial class MathExtensions
{
    /// <summary>
    /// Calculates the nth Fibonacci number.
    /// </summary>
    /// <param name="n">The position of the Fibonacci number to calculate (0-based index).</param>
    /// <returns>The nth Fibonacci number.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when n is negative.</exception>
    public static long Fibonacci(this int n)
    {
        if (n < 0)
            throw new ArgumentOutOfRangeException(nameof(n), "Fibonacci sequence is not defined for negative indices.");

        if (n <= 1)
            return n;

        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}