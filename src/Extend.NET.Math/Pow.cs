namespace Extend.NET.Math;

public static partial class MathExtensions
{
    /// <summary>
    /// Raises a number to the specified power using the exponentiation by squaring algorithm.
    /// </summary>
    /// <param name="baseNumber">The base number.</param>
    /// <param name="exponent">The exponent.</param>
    /// <returns>The result of raising the base number to the specified power.</returns>
    public static double Pow(this double baseNumber, int exponent)
    {
        if (exponent == 0)
            return 1;

        if (exponent < 0)
        {
            baseNumber = 1 / baseNumber;
            exponent = -exponent;
        }

        double result = 1;
        while (exponent > 0)
        {
            if ((exponent & 1) == 1)
                result *= baseNumber;
            
            baseNumber *= baseNumber;
            exponent >>= 1;
        }

        return result;
    }
}