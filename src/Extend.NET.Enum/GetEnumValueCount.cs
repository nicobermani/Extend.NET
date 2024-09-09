namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the count of values in the enum.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <returns>The number of values defined in the enum.</returns>
    public static int GetEnumValueCount<T>(this T value) where T : System.Enum
    {
        return System.Enum.GetValues(typeof(T)).Length;
    }
}