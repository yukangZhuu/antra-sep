namespace Assignment_02;

public class MostFrequent
{
    public static int FindMostFrequent(int[] array)
    {
        int result = 0;
        int maxFreq = 0;
        
        Dictionary<int, int> freq = new Dictionary<int, int>();

        foreach (int num in array)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq.Add(num, 1);
            }

            if (freq[num] > maxFreq)
            {
                maxFreq = freq[num];
                result = num;
            }
        }

        return result;

    }
}