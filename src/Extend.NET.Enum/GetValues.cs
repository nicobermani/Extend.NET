namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets an array of all values of the specified enum type.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <returns>An array containing all values of the enum type.</returns>
    public static T[] GetValues<T>(this T value) where T : System.Enum
    {
        return (T[]) System.Enum.GetValues(typeof(T));
    }
}