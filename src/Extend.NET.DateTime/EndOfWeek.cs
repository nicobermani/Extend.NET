namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Returns the last day of the week for the given date.
    /// </summary>
    /// <param name="date">The date to get the end of the week for.</param>
    /// <param name="endOfWeek">The day considered as the end of the week (default is Saturday).</param>
    /// <returns>A new DateTime representing the last day of the week.</returns>
    public static System.DateTime EndOfWeek(this System.DateTime date, DayOfWeek endOfWeek = DayOfWeek.Saturday)
    {
        var diff = (7 + (endOfWeek - date.DayOfWeek)) % 7;
        return date.AddDays(diff).Date;
    }
}