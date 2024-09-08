namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Returns the last day of the month for the given date.
    /// </summary>
    /// <param name="date">The date to get the end of the month for.</param>
    /// <returns>A new DateTime representing the last day of the month.</returns>
    public static System.DateTime EndOfMonth(this System.DateTime date)
    {
        return new System.DateTime(date.Year, date.Month, System.DateTime.DaysInMonth(date.Year, date.Month));
    }
}