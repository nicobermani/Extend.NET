namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the enum value at the specified index.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="index">The index of the enum value to retrieve.</param>
    /// <returns>The enum value at the specified index.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the index is out of range.</exception>
    public static T GetEnumValueByIndex<T>(this T value, int index) where T : System.Enum
    {
        T[] values = (T[]) System.Enum.GetValues(typeof(T));
        if (index < 0 || index >= values.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), $"Index must be between 0 and {values.Length - 1}");
        }
        return values[index];
    }
}