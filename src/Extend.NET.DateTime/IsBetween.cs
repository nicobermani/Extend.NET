using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Determines whether the given date is between two specified dates.
    /// </summary>
    /// <param name="date">The date to check.</param>
    /// <param name="startDate">The start date of the range.</param>
    /// <param name="endDate">The end date of the range.</param>
    /// <param name="inclusive">If true, the comparison is inclusive; otherwise, it's exclusive.</param>
    /// <returns>True if the date is within the specified range; otherwise, false.</returns>
    public static bool IsBetween(this DateTime date, DateTime startDate, DateTime endDate, bool inclusive = true)
    {
        return inclusive
            ? date >= startDate && date <= endDate
            : date > startDate && date < endDate;
    }
}