using System.ComponentModel;
using System.Reflection;

namespace Extend.NET.Enum;

public static partial class EnumExtensions
{
    /// <summary>
    /// Gets the description of an enum value.
    /// </summary>
    /// <param name="value">The enum value.</param>
    /// <returns>The description of the enum value if it has a DescriptionAttribute, otherwise the enum value's name.</returns>
    public static string GetDescription(this System.Enum value)
    {
        var field = value.GetType().GetField(value.ToString());
        var attribute = field.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description ?? value.ToString();
    }
}