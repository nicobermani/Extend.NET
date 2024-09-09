namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Checks if the given integer value is within the range of defined enum values.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="intValue">The integer value to check.</param>
    /// <returns>True if the value is within the range of defined enum values, otherwise false.</returns>
    public static bool IsEnumValueInRange<T>(this T value, int intValue) where T : System.Enum
    {
        var (min, max) = value.GetEnumValueRange();
        return intValue >= min && intValue <= max;
    }
}