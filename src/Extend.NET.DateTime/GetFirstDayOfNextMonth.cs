namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Gets the first day of the next month from the given date.
    /// </summary>
    /// <param name="date">The starting date.</param>
    /// <returns>A new DateTime representing the first day of the next month.</returns>
    public static System.DateTime GetFirstDayOfNextMonth(this System.DateTime date)
    {
        return new System.DateTime(date.Year, date.Month, 1).AddMonths(1);
    }
}