namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the name of the enum value.
    /// </summary>
    /// <param name="value">The enum value.</param>
    /// <returns>The name of the enum value as a string.</returns>
    public static string GetName(this System.Enum value)
    {
        return System.Enum.GetName(value.GetType(), value);
    }
}