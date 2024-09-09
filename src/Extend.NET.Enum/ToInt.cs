namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Converts the enum value to its underlying integer value.
    /// </summary>
    /// <param name="value">The enum value to convert.</param>
    /// <returns>The integer value of the enum.</returns>
    public static int ToInt(this System.Enum value)
    {
        return Convert.ToInt32(value);
    }
}