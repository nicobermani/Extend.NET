namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets the enum value that matches the specified display name.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="displayName">The display name to search for.</param>
        /// <returns>The enum value with the matching display name, or default if not found.</returns>
        public static T GetEnumValueByDisplayName<T>(this Type enumType, string displayName) where T : struct, System.Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field, typeof(System.ComponentModel.DataAnnotations.DisplayAttribute)) is System.ComponentModel.DataAnnotations.DisplayAttribute attribute)
                {
                    if (attribute.Name == displayName)
                        return (T)field.GetValue(null);
                }
            }
            return default;
        }
    }
}