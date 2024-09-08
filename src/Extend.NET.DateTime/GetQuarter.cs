using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the quarter of the year for the given date.
    /// </summary>
    /// <param name="date">The date to get the quarter for.</param>
    /// <returns>An integer representing the quarter (1-4).</returns>
    public static int GetQuarter(this DateTime date)
    {
        return (date.Month - 1) / 3 + 1;
    }
}