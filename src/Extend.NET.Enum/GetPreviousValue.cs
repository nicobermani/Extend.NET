namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the previous value in the enum, or the last value if the current value is the first one.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">The current enum value.</param>
    /// <returns>The previous value in the enum, or the last value if the current value is the first one.</returns>
    public static T GetPreviousValue<T>(this T value) where T : System.Enum
    {
        var values = (T[]) System.Enum.GetValues(typeof(T));
        var index = Array.IndexOf(values, value);
        return (index > 0) ? values[index - 1] : values[values.Length - 1];
    }
}