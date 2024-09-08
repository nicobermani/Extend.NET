namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Determines whether the given date is in the past.
    /// </summary>
    /// <param name="date">The date to check.</param>
    /// <returns>True if the date is in the past; otherwise, false.</returns>
    public static bool IsInPast(this System.DateTime date)
    {
        return date < System.DateTime.Now;
    }
}