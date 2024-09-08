using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the next occurrence of the specified day of the week after the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <param name="dayOfWeek">The day of the week to find the next occurrence of.</param>
    /// <returns>A new DateTime representing the next occurrence of the specified day of the week.</returns>
    public static DateTime GetNextOccurrence(this DateTime date, DayOfWeek dayOfWeek)
    {
        int daysToAdd = ((int)dayOfWeek - (int)date.DayOfWeek + 7) % 7;
        return date.AddDays(daysToAdd == 0 ? 7 : daysToAdd);
    }
}