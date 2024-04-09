namespace Assignment_01;

public class DaysOldCalculator
{
    public static void Calculate(int year, int month, int day)
    {
        DateTime birthDate = new DateTime(year, month, day); // Replace with actual birth date
        DateTime currentDate = DateTime.Today;

        TimeSpan ageInDays = currentDate - birthDate;
        Console.WriteLine($"You are {ageInDays.Days} days old.");

        int daysToNextAnniversary = 10000 - (ageInDays.Days % 10000);
        DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);

        Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversary.ToShortDateString()}.");
    }
}