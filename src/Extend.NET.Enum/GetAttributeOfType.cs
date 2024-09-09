namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets the first attribute of the specified type from the enum value.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <typeparam name="TAttribute">The attribute type to retrieve.</typeparam>
        /// <param name="value">The enum value.</param>
        /// <returns>The first attribute of the specified type, or null if not found.</returns>
        public static TAttribute GetAttributeOfType<T, TAttribute>(this T value) where T : struct, Enum where TAttribute : Attribute
        {
            return value.GetType().GetField(value.ToString())
                .GetCustomAttributes(typeof(TAttribute), false)
                .FirstOrDefault() as TAttribute;
        }
    }
}