namespace Assignment_02;

public class LongestSequence
{
    public static int[] FindLongestEqualSequence(int[] array)
    {
        int resultStart = 0;
        int resultEnd = 0;
        int start = 0;

        for (int end = 0; end < array.Length; end++)
        {
            if (array[end] != array[start])
            {
                start = end;
            }

            if (end - start > resultEnd - resultStart)
            {
                resultEnd = end;
                resultStart = start;
            }
        }

        int resultLength = resultEnd - resultStart + 1;
        int resultvalue = array[resultStart];

        int[] result = new int[resultLength];
        Array.Fill(result, resultvalue);

        return result;
    }
}