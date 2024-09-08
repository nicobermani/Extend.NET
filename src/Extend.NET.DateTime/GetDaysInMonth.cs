namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the number of days in the month of the given date.
    /// </summary>
    /// <param name="date">The date to get the number of days in the month for.</param>
    /// <returns>The number of days in the month.</returns>
    public static int GetDaysInMonth(this System.DateTime date)
    {
        return System.DateTime.DaysInMonth(date.Year, date.Month);
    }
}