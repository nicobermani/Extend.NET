namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Checks if a specific flag is set in the enum value.
    /// </summary>
    /// <typeparam name="T">The enum type.</typeparam>
    /// <param name="value">The enum value to check.</param>
    /// <param name="flag">The flag to check for.</param>
    /// <returns>True if the flag is set, otherwise false.</returns>
    public static bool IsEnumFlagSet<T>(this T value, T flag) where T : System.Enum
    {
        long flagValue = Convert.ToInt64(flag);
        return (Convert.ToInt64(value) & flagValue) == flagValue;
    }
}