using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Returns the first day of the month for the given date.
    /// </summary>
    /// <param name="date">The date to get the start of the month for.</param>
    /// <returns>A new DateTime representing the first day of the month.</returns>
    public static DateTime StartOfMonth(this DateTime date)
    {
        return new DateTime(date.Year, date.Month, 1);
    }
}