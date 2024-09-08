using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Determines whether the year of the given date is a leap year.
    /// </summary>
    /// <param name="date">The date to check.</param>
    /// <returns>True if the year is a leap year; otherwise, false.</returns>
    public static bool IsLeapYear(this DateTime date)
    {
        return DateTime.IsLeapYear(date.Year);
    }
}