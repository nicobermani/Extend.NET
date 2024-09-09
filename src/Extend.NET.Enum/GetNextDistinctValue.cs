namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets the next distinct value in the enum, skipping duplicate integer values.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The current enum value.</param>
        /// <returns>The next distinct enum value, or the first value if the current value is the last distinct one.</returns>
        public static T GetNextDistinctValue<T>(this T value) where T : struct, Enum
        {
            var values = Enum.GetValues(typeof(T)).Cast<T>().Distinct().ToList();
            int index = values.IndexOf(value);
            return index < values.Count - 1 ? values[index + 1] : values[0];
        }
    }
}