namespace Extend.NET.Math;

public static partial class MathExtensions
{
    /// <summary>
    /// Clamps a value between a minimum and maximum value.
    /// </summary>
    /// <param name="value">The value to clamp.</param>
    /// <param name="min">The minimum value.</param>
    /// <param name="max">The maximum value.</param>
    /// <returns>The clamped value.</returns>
    public static int Clamp(this int value, int min, int max)
    {
        if (min > max)
            throw new ArgumentException("min cannot be greater than max");

        if (value < min)
            return min;
        if (value > max)
            return max;
        return value;
    }
}