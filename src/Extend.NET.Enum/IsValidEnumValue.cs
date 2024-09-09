namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Checks if the given value is a valid enum value for the specified enum type.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="enumValue">The value to check.</param>
    /// <returns>True if the value is a valid enum value, otherwise false.</returns>
    public static bool IsValidEnumValue<T>(this T value, object enumValue) where T : System.Enum
    {
        return System.Enum.IsDefined(typeof(T), enumValue);
    }
}