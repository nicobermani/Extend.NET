namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Checks if the given value is a valid enum value for the specified enum type.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="enumType">The enum type.</param>
    /// <param name="value">The value to check.</param>
    /// <returns>True if the value is a valid enum value, false otherwise.</returns>
    public static bool IsValidEnumValue<T>(this Type enumType, T value) where T : struct
    {
        return System.Enum.IsDefined(typeof(T), value);
    }
}