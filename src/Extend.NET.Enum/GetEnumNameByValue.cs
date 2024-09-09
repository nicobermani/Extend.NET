namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the name of the enum value by its underlying integer value.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="enumValue">The integer value of the enum.</param>
    /// <returns>The name of the enum value, or null if not found.</returns>
    public static string GetEnumNameByValue<T>(this T value, int enumValue) where T : System.Enum
    {
        return System.Enum.IsDefined(typeof(T), enumValue) ? System.Enum.GetName(typeof(T), enumValue) : null;
    }
}