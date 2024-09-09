using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets the display name of an enum value.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <returns>The display name of the enum value if it has a DisplayAttribute, otherwise the enum value's name.</returns>
        public static string GetDisplayName(this System.Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = field.GetCustomAttribute<DisplayAttribute>();
            return attribute?.Name ?? value.ToString();
        }
    }
}