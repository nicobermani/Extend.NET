namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Returns the last day of the year for the given date.
    /// </summary>
    /// <param name="date">The date to get the last day of the year for.</param>
    /// <returns>A new DateTime representing the last day of the year.</returns>
    public static System.DateTime GetLastDayOfYear(this System.DateTime date)
    {
        return new System.DateTime(date.Year, 12, 31);
    }
}