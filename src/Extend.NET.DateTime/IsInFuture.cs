using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Determines whether the given date is in the future.
    /// </summary>
    /// <param name="date">The date to check.</param>
    /// <returns>True if the date is in the future; otherwise, false.</returns>
    public static bool IsInFuture(this DateTime date)
    {
        return date > DateTime.Now;
    }
}