namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Returns the first day of the year for the given date.
    /// </summary>
    /// <param name="date">The date to get the first day of the year for.</param>
    /// <returns>A new DateTime representing the first day of the year.</returns>
    public static System.DateTime GetFirstDayOfYear(this System.DateTime date)
    {
        return new System.DateTime(date.Year, 1, 1);
    }
}