namespace Extend.NET.DateTime;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Determines whether the given date is in the future.
    /// </summary>
    /// <param name="date">The date to check.</param>
    /// <returns>True if the date is in the future; otherwise, false.</returns>
    public static bool IsInFuture(this System.DateTime date)
    {
        return date > System.DateTime.Now;
    }
}