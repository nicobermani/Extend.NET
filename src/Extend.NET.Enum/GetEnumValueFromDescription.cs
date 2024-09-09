namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets the enum value that matches the specified description.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="description">The description to search for.</param>
        /// <returns>The enum value with the matching description, or default if not found.</returns>
        public static T GetEnumValueFromDescription<T>(this Type enumType, string description) where T : struct, System.Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field, typeof(System.ComponentModel.DescriptionAttribute)) is System.ComponentModel.DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                        return (T)field.GetValue(null);
                }
            }
            return default;
        }
    }
}