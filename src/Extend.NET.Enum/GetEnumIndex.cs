namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the index of the enum value in the enum definition order.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">The enum value to get the index for.</param>
    /// <returns>The zero-based index of the enum value, or -1 if not found.</returns>
    public static int GetEnumIndex<T>(this T value) where T : System.Enum
    {
        return Array.IndexOf(System.Enum.GetValues(typeof(T)), value);
    }
}