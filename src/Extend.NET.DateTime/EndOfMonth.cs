using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Returns the last day of the month for the given date.
    /// </summary>
    /// <param name="date">The date to get the end of the month for.</param>
    /// <returns>A new DateTime representing the last day of the month.</returns>
    public static DateTime EndOfMonth(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
    }
}