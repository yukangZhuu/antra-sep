namespace Assignment_02;

public class RotateSum
{
    public static int[] solve(string strArray, int k)
    {
        int[] array = ConvertStringToIntArray(strArray);
        int[] result = new int[array.Length];

        k = k % array.Length;
        
        for (int i = 1; i <= k; i++)
        {
            int temp = array[array.Length - 1];
            for (int j = array.Length - 1; j > 0; j--)
            {
                array[j] = array[j - 1];
            }

            array[0] = temp;

            for (int j = 0; j < array.Length; j++)
            {
                result[j] += array[j];
            }
        }

        return result;
    }
    
    private static int[] ConvertStringToIntArray(string input)
    {
        string[] stringNumbers = input.Split(' ');
        
        int[] intNumbers = new int[stringNumbers.Length];
        
        for (int i = 0; i < stringNumbers.Length; i++)
        {
            intNumbers[i] = int.Parse(stringNumbers[i]);
        }

        return intNumbers;
    }
}