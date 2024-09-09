namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Determines whether the specified name exists in the enum.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <param name="name">The name to check for existence in the enum.</param>
    /// <returns>True if the name exists in the enum, otherwise false.</returns>
    public static bool IsDefinedName<T>(this T value, string name) where T : System.Enum
    {
        return System.Enum.TryParse(typeof(T), name, out _);
    }
}