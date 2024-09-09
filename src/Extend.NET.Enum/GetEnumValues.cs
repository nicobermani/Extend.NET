namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets all values of the enum as a list.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">An instance of the enum type (used for type inference).</param>
        /// <returns>A list containing all values of the enum.</returns>
        public static List<T> GetEnumValues<T>(this T value) where T : System.Enum
        {
            return new List<T>((T[])System.Enum.GetValues(typeof(T)));
        }
    }
}