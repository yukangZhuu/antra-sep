namespace Assignment_01;

using System.Numerics;

public class CenturyConverter
{
    public static void ConvertCenturies(int centuries)
    {
        int years = centuries * 100;
        int days = (int)(years * 365.2422); 
        int hours = days * 24;
        long minutes = (long)hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        BigInteger microseconds = new BigInteger(milliseconds) * 1000;
        BigInteger nanoseconds = microseconds * 1000;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = " +
                          $"{minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = " +
                          $"{microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}