namespace Assignment_01;

public class NumberGuessing
{
    public static void PlayGame()
    {
        int correctNumber = new Random().Next(3) + 1;
        Console.WriteLine("Guess a number between 1 and 3:");

        int guessedNumber = int.Parse(Console.ReadLine());

        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Your guess is outside the valid range of numbers.");
        }
        else if (guessedNumber < correctNumber)
        {
            Console.WriteLine("Your guess is too low.");
        }
        else if (guessedNumber > correctNumber)
        {
            Console.WriteLine("Your guess is too high.");
        }
        else
        {
            Console.WriteLine("Congratulations! You guessed the correct number!");
        }
    }
}