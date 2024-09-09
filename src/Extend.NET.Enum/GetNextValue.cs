namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        /// <summary>
        /// Gets the next value in the enum, or the first value if the current value is the last one.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">The current enum value.</param>
        /// <returns>The next value in the enum, or the first value if the current value is the last one.</returns>
        public static T GetNextValue<T>(this T value) where T : System.Enum
        {
            T[] values = (T[])System.Enum.GetValues(typeof(T));
            int index = Array.IndexOf(values, value);
            return (index < values.Length - 1) ? values[index + 1] : values[0];
        }
    }
}