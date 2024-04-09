namespace Assignment_01;

public class FizzBuzz
{
    public static void PlayGame(int upTo)
    {
        for (int i = 1; i <= upTo; i++)
        {
            bool divisibleBy3 = i % 3 == 0;
            bool divisibleBy5 = i % 5 == 0;

            if (divisibleBy3 && divisibleBy5)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (divisibleBy3)
            {
                Console.WriteLine("fizz");
            }
            else if (divisibleBy5)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}