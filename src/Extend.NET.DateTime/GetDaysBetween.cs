using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Calculates the number of days between two dates.
    /// </summary>
    /// <param name="startDate">The start date.</param>
    /// <param name="endDate">The end date.</param>
    /// <returns>The number of days between the two dates.</returns>
    public static int GetDaysBetween(this DateTime startDate, DateTime endDate)
    {
        return (int)(endDate.Date - startDate.Date).TotalDays;
    }
}