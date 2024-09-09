namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets an array of the names of all the constants in the specified enumeration.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <returns>A string array of the names of the constants in the enumeration.</returns>
    public static string[] GetNames<T>(this T value) where T : System.Enum
    {
        return System.Enum.GetNames(typeof(T));
    }
}