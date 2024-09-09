namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Determines whether the specified value exists in the enum.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="enumValue">The value to check for existence in the enum.</param>
    /// <returns>True if the value exists in the enum, otherwise false.</returns>
    public static bool IsDefined<T>(this T value, object enumValue) where T : System.Enum
    {
        return System.Enum.IsDefined(typeof(T), enumValue);
    }
}