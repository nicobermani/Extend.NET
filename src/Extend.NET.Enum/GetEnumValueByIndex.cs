namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the enum value at the specified index.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="enumType">The enum type.</param>
    /// <param name="index">The index of the enum value to retrieve.</param>
    /// <returns>The enum value at the specified index, or default if the index is out of range.</returns>
    public static T GetEnumValueByIndex<T>(this Type enumType, int index) where T : struct, System.Enum
    {
        var values = System.Enum.GetValues(typeof(T)).Cast<T>().ToArray();
        return index >= 0 && index < values.Length ? values[index] : default;
    }
}