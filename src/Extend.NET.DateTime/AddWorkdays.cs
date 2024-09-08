using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Adds a specified number of workdays to the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <param name="days">The number of workdays to add.</param>
    /// <returns>A new DateTime that is the specified number of workdays after the input date.</returns>
    public static DateTime AddWorkdays(this DateTime date, int days)
    {
        while (days > 0)
        {
            date = date.AddDays(1);
            if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
            {
                days--;
            }
        }
        return date;
    }
}