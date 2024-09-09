namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Converts an integer to its corresponding enum value.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="intValue">The integer value to convert.</param>
    /// <returns>The enum value corresponding to the integer value.</returns>
    /// <exception cref="ArgumentException">Thrown when the integer value is not defined in the enum.</exception>
    public static T GetEnumValueFromInt<T>(this T value, int intValue) where T : System.Enum
    {
        if (!System.Enum.IsDefined(typeof(T), intValue))
            throw new ArgumentException($"The value {intValue} is not defined in the enum {typeof(T).Name}");
        return (T) System.Enum.ToObject(typeof(T), intValue);
    }
}