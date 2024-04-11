namespace Assignment_03;

public class Utils
{
    public static void Reverse(int[] array)
    {
        int i = 0;
        int j = array.Length - 1;
        while (i < j)
        {
            (array[i], array[j]) = (array[j], array[i]);
            i++;
            j--;
        }
    }

    public static void PrintNumbers(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    public static int[] GenerateNumbers(int n)
    {
        int[] array = new int[n];
        for (int i = 1; i <= n; i++)
        {
            array[i - 1] = i;
        }

        return array;
    }

    public static int Fibonacci(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}