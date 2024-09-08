using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the last day of the previous month from the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <returns>A new DateTime representing the last day of the previous month.</returns>
    public static DateTime GetLastDayOfPreviousMonth(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, 1).AddDays(-1);
    }
}