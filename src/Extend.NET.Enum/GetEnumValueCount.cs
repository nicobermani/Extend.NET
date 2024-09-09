namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the count of distinct values in the enum.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="enumType">The enum type.</param>
    /// <returns>The count of distinct enum values.</returns>
    public static int GetEnumValueCount<T>(this Type enumType) where T : struct, System.Enum
    {
        return System.Enum.GetValues(typeof(T)).Cast<T>().Distinct().Count();
    }
}