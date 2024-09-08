using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the next workday (Monday through Friday) from the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <returns>The next workday after the given date.</returns>
    public static DateTime GetNextWorkday(this DateTime date)
    {
        do
        {
            date = date.AddDays(1);
        } while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);

        return date;
    }
}