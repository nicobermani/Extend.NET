namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Parses a string to the enum value, ignoring case.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="stringValue">The string value to parse.</param>
    /// <returns>The enum value corresponding to the string value.</returns>
    /// <exception cref="ArgumentException">Thrown when the string value is not defined in the enum.</exception>
    public static T ParseIgnoreCase<T>(this T value, string stringValue) where T : System.Enum
    {
        return (T) System.Enum.Parse(typeof(T), stringValue, true);
    }
}