namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Determines whether the given date is a business day (Monday through Friday).
    /// </summary>
    /// <param name="date">The date to check.</param>
    /// <returns>True if the date is a business day; otherwise, false.</returns>
    public static bool IsBusinessDay(this System.DateTime date)
    {
        return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
    }
}