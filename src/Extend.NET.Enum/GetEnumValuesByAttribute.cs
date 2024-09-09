namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all enum values that have the specified attribute with a matching property value.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <typeparam name="TAttribute">The attribute type to filter by.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="propertyName">The name of the attribute property to check.</param>
        /// <param name="propertyValue">The value of the attribute property to match.</param>
        /// <returns>An IEnumerable of enum values that have the specified attribute with a matching property value.</returns>
        public static IEnumerable<T> GetEnumValuesByAttribute<T, TAttribute>(this Type enumType, string propertyName, object propertyValue)
            where T : struct, System.Enum
            where TAttribute : Attribute
        {
            return System.Enum.GetValues(typeof(T))
                .Cast<T>()
                .Where(value => 
                {
                    var attribute = value.GetType().GetField(value.ToString())
                        .GetCustomAttributes(typeof(TAttribute), false)
                        .FirstOrDefault() as TAttribute;
                    if (attribute == null) return false;
                    var property = typeof(TAttribute).GetProperty(propertyName);
                    return property != null && property.GetValue(attribute)?.Equals(propertyValue) == true;
                });
        }
    }
}