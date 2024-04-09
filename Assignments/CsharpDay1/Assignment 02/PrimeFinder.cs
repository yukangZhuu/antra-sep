namespace Assignment_02;

public class PrimeFinder
{
    public static int[] FindPrimesInRange(int start, int end)
    {
        List<int> results = new List<int>();

        for (int i = start; i <= end; i++)
        {
            if (IsPrime(i))
            {
                results.Add(i);
            }
        }

        return results.ToArray();
    }


    private static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;

        for (int i = 2; i < n / 2; i++)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}