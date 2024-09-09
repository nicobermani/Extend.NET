namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Converts the enum value to its underlying long value.
    /// </summary>
    /// <param name="value">The enum value to convert.</param>
    /// <returns>The long value of the enum.</returns>
    public static long ToLong(this System.Enum value)
    {
        return Convert.ToInt64(value);
    }
}