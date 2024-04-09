namespace Assignment_01;

public class UserGreeting
{
    public static void Greet()
    {
        DateTime currentTime = DateTime.Now; // Example time

        int hour = currentTime.Hour;

        if (hour >= 5 && hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
        if (hour >= 12 && hour < 17)
        {
            Console.WriteLine("Good Afternoon");
        }
        if (hour >= 17 && hour < 21)
        {
            Console.WriteLine("Good Evening");
        }
        if (hour >= 21 || hour < 5)
        {
            Console.WriteLine("Good Night");
        }        
    }
}