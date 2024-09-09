namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Converts a string to its corresponding enum value.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="stringValue">The string value to convert.</param>
    /// <param name="ignoreCase">True to ignore case; false to consider case.</param>
    /// <returns>The enum value corresponding to the string value.</returns>
    /// <exception cref="ArgumentException">Thrown when the string value is not defined in the enum.</exception>
    public static T GetEnumValueFromString<T>(this T value, string stringValue, bool ignoreCase = false)
        where T : System.Enum
    {
        if (!System.Enum.TryParse(typeof(T), stringValue, ignoreCase, out var result))
            throw new ArgumentException($"The value '{stringValue}' is not defined in the enum {typeof(T).Name}");
        return (T)result;
    }
}