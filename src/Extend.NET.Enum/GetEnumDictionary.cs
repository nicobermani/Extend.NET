namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Creates a dictionary of enum values with their names as keys.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <returns>A dictionary with enum names as keys and enum values as values.</returns>
    public static Dictionary<string, T> GetEnumDictionary<T>(this T value) where T : System.Enum
    {
        return System.Enum.GetValues(typeof(T))
            .Cast<T>()
            .ToDictionary(v => v.ToString(), v => v);
    }
}