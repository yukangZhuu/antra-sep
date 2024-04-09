namespace Assignment_02;

public class ReverseLetters
{
    public static void printReversed(string str)
    {
        //Method 1: Convert the string to char array, reverse it, then convert it to string again
        // char[] array = str.ToCharArray();
        // int i = 0;
        // int j = array.Length - 1;
        // while (i < j)
        // {
        //     (array[i], array[j]) = (array[j], array[i]);
        //     i++;
        //     j--;
        // }
        //
        // string reversed = new string(array);
        // Console.WriteLine("Reversed string: " + reversed);
        
        
        //Method 2: Print the letters of the string in back direction (from the last to the first) in a for-loop
        Console.WriteLine("Reversed string: ");
        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
    }
}