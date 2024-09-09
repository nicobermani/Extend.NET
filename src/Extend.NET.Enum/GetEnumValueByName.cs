namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets the enum value by its name.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <param name="name">The name of the enum value.</param>
        /// <returns>The enum value corresponding to the given name.</returns>
        public static T GetEnumValueByName<T>(this Type enumType, string name) where T : struct, Enum
        {
            return (T)Enum.Parse(typeof(T), name);
        }
    }
}