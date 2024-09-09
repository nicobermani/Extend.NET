namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Determines whether the enum value has any of the specified flags.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The enum value to check.</param>
        /// <param name="flags">The flags to check for.</param>
        /// <returns>True if the enum value has any of the specified flags, false otherwise.</returns>
        public static bool HasAnyFlag<T>(this T value, params T[] flags) where T : struct, System.Enum
        {
            var lValue = Convert.ToInt64(value);
            return flags.Any(flag => (lValue & Convert.ToInt64(flag)) != 0);
        }
    }
}