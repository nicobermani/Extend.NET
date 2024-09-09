namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all enum values that have an attribute of the specified type.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <typeparam name="TAttribute">The attribute type to filter by.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <returns>An IEnumerable of enum values that have an attribute of the specified type.</returns>
        public static IEnumerable<T> GetEnumValuesWithAttributeOfType<T, TAttribute>(this Type enumType)
            where T : struct, System.Enum
            where TAttribute : Attribute
        {
            return System.Enum.GetValues(typeof(T))
                .Cast<T>()
                .Where(value => value.GetType().GetField(value.ToString())
                    .GetCustomAttributes(typeof(TAttribute), false).Any());
        }
    }
}