namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the name of the enum value by its underlying integer value.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="enumType">The enum type.</param>
    /// <param name="value">The underlying integer value of the enum.</param>
    /// <returns>The name of the enum value, or null if not found.</returns>
    public static string GetEnumNameByValue<T>(this Type enumType, int value) where T : struct, System.Enum
    {
        return System.Enum.IsDefined(typeof(T), value) ? System.Enum.GetName(typeof(T), value) : null;
    }
}