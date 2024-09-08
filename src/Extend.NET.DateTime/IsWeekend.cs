namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Determines whether the given date falls on a weekend.
    /// </summary>
    /// <param name="date">The date to check.</param>
    /// <returns>True if the date is a Saturday or Sunday; otherwise, false.</returns>
    public static bool IsWeekend(this System.DateTime date)
    {
        return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}