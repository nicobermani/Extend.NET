namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the underlying type of the enum.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">An instance of the enum type (used for type inference).</param>
    /// <returns>The underlying type of the enum.</returns>
    public static Type GetUnderlyingType<T>(this T value) where T : System.Enum
    {
        return System.Enum.GetUnderlyingType(typeof(T));
    }
}