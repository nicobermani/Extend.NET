namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets all enum values as key-value pairs, where the key is the enum value and the value is its string representation.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="enumType">The enum type.</param>
    /// <returns>An IEnumerable of KeyValuePairs representing the enum values.</returns>
    public static IEnumerable<KeyValuePair<T, string>> GetEnumValuesAsKeyValuePairs<T>(this Type enumType)
        where T : struct, System.Enum
    {
        return System.Enum.GetValues(typeof(T))
            .Cast<T>()
            .Select(e => new KeyValuePair<T, string>(e, e.ToString()));
    }
}