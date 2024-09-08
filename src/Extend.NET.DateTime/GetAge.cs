using System;

public static partial class DateTimeExtensions
{
    /// <summary>
    /// Calculates the age based on the given date and the current date.
    /// </summary>
    /// <param name="birthDate">The birth date to calculate the age from.</param>
    /// <returns>The calculated age in years.</returns>
    public static int GetAge(this DateTime birthDate)
    {
        var today = DateTime.Today;
        var age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age)) age--;
        return age;
    }
}