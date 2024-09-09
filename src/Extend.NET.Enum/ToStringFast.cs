using System.Collections.Concurrent;
using System.Reflection;

namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    private static readonly ConcurrentDictionary<System.Enum, string> _enumStringCache = new();

    /// <summary>
    /// Converts the enum value to its string representation using a cached approach for better performance.
    /// </summary>
    /// <param name="value">The enum value to convert.</param>
    /// <returns>The string representation of the enum value.</returns>
    public static string ToStringFast(this System.Enum value)
    {
        return _enumStringCache.GetOrAdd(value, enumValue =>
        {
            FieldInfo fi = enumValue.GetType().GetField(enumValue.ToString());
            return fi.Name;
        });
    }
}