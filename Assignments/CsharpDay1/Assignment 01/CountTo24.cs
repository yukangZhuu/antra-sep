namespace Assignment_01;

public class CountTo24
{
    public static void Count()
    {
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine();
            for (int j = 0; j <= 24; j += i)
            {
                Console.Write(j);
                Console.Write(" ");
            }
        }
    }
}