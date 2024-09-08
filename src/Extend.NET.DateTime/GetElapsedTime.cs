namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Calculates the elapsed time between the given date and the current date and time.
    /// </summary>
    /// <param name="startDate">The starting date.</param>
    /// <returns>A TimeSpan representing the elapsed time.</returns>
    public static TimeSpan GetElapsedTime(this System.DateTime startDate)
    {
        return System.DateTime.Now - startDate;
    }
}