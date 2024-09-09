namespace Extend.NET.Enum
{
    public static partial class EnumExtensions
    {
        private static readonly Random _random = new Random();

        /// <summary>
        /// Gets a random value from the enum.
        /// </summary>
        /// <typeparam name="T">The enum type.</typeparam>
        /// <param name="value">An instance of the enum type (used for type inference).</param>
        /// <returns>A random value from the enum.</returns>
        public static T GetRandomValue<T>(this T value) where T : System.Enum
        {
            T[] values = (T[])System.Enum.GetValues(typeof(T));
            return values[_random.Next(values.Length)];
        }
    }
}