namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the range of integer values used in the enum.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <returns>A tuple containing the minimum and maximum integer values used in the enum.</returns>
    public static (int Min, int Max) GetEnumValueRange<T>(this T value) where T : System.Enum
    {
        var values = System.Enum.GetValues(typeof(T)).Cast<int>();
        return (values.Min(), values.Max());
    }
}