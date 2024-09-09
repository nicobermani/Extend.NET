namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets all enum values sorted by their underlying integer value.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="enumType">The enum type.</param>
    /// <returns>An IEnumerable of enum values sorted by their underlying integer value.</returns>
    public static IEnumerable<T> GetEnumValuesSorted<T>(this Type enumType) where T : struct, System.Enum
    {
        return System.Enum.GetValues(typeof(T))
            .Cast<T>()
            .OrderBy(e => Convert.ToInt32(e));
    }
}