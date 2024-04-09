namespace Assignment_01;

public class PrintPyramid
{
    //input: number of rows (height) of the pyramid
    public static void PrintRow(int n)
    {
        for (int i = 0; i < n; i++)
        {
            int numOfStars = i * 2 - 1;
            int numOfSpacesHalf = n - i - 1;
            
            Console.WriteLine();
            //print leading spaces
            for (int j = 0; j < numOfSpacesHalf; j++)
            {
                Console.Write(" ");
            }
            //print stars
            for (int j = 0; j < numOfStars; j++)
            {
                Console.Write("*");
            }           
            //print trailing spaces
            for (int j = 0; j < numOfSpacesHalf; j++)
            {
                Console.Write(" ");
            }            
        }
    }
}