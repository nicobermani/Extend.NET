namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets all flags set in the enum value.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">The enum value to get flags from.</param>
    /// <returns>An IEnumerable of all flags set in the enum value.</returns>
    public static IEnumerable<T> GetFlags<T>(this T value) where T : System.Enum
    {
        return System.Enum.GetValues(typeof(T))
            .Cast<T>()
            .Where(flag => value.HasFlag(flag));
    }
}