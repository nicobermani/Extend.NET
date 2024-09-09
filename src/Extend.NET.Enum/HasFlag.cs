namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Determines whether the enum value has the specified flag.
        /// </summary>
        /// <param name="value">The enum value.</param>
        /// <param name="flag">The flag to check for.</param>
        /// <returns>True if the enum value has the specified flag, otherwise false.</returns>
        public static bool HasFlag(this System.Enum value, System.Enum flag)
        {
            return (Convert.ToInt64(value) & Convert.ToInt64(flag)) != 0;
        }
    }
}