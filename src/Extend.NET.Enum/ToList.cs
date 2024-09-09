namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Converts an enum type to a list of its values.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <returns>A list containing all values of the enum.</returns>
    public static List<T> ToList<T>(this T value) where T : System.Enum
    {
        return System.Enum.GetValues(typeof(T)).Cast<T>().ToList();
    }
}