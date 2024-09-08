using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the next weekday (Monday to Friday) from the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <returns>A new DateTime representing the next weekday.</returns>
    public static DateTime GetNextWeekday(this DateTime date)
    {
        do
        {
            date = date.AddDays(1);
        } while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);

        return date;
    }
}