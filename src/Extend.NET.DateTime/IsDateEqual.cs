using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Compares two DateTime objects for date equality, ignoring the time component.
    /// </summary>
    /// <param name="date">The first date to compare.</param>
    /// <param name="otherDate">The second date to compare.</param>
    /// <returns>True if the dates are equal (ignoring time); otherwise, false.</returns>
    public static bool IsDateEqual(this DateTime date, DateTime otherDate)
    {
        return date.Date == otherDate.Date;
    }
}