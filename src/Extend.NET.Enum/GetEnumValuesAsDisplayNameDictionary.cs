namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all enum values as a dictionary with display names as keys and enum values as values.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <returns>A dictionary with display names as keys and enum values as values.</returns>
        public static Dictionary<string, T> GetEnumValuesAsDisplayNameDictionary<T>(this Type enumType) where T : struct, System.Enum
        {
            return System.Enum.GetValues(typeof(T))
                .Cast<T>()
                .ToDictionary(
                    value => value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(System.ComponentModel.DataAnnotations.DisplayAttribute), false)
                        .Cast<System.ComponentModel.DataAnnotations.DisplayAttribute>()
                        .FirstOrDefault()?.Name ?? value.ToString(),
                    value => value
                );
        }
    }
}