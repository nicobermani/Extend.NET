namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all enum values as an array of strings.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="enumType">The enum type.</param>
        /// <returns>An array of strings representing the enum values.</returns>
        public static string[] GetEnumValuesAsStringArray<T>(this Type enumType) where T : struct, System.Enum
        {
            return System.Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(e => e.ToString())
                .ToArray();
        }
    }
}