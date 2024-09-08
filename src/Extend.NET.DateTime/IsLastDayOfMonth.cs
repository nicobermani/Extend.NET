namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Determines whether the given date is the last day of its month.
    /// </summary>
    /// <param name="date">The date to check.</param>
    /// <returns>True if the date is the last day of the month; otherwise, false.</returns>
    public static bool IsLastDayOfMonth(this System.DateTime date)
    {
        return date.Date == new System.DateTime(date.Year, date.Month, System.DateTime.DaysInMonth(date.Year, date.Month));
    }
}