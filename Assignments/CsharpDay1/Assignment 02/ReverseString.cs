namespace Assignment_02;
using System.Text;
using System.Text.RegularExpressions;

public class ReverseString
{
    public static string Reverse(string sentence)
    {
        var matches = Regex.Matches(sentence, @"(\w+|[.,:;=()\[\]&\""\'\\\/!? ]+)");
        var words = new Stack<string>();
        var nonWords = new Queue<string>();

        foreach (Match match in matches)
        {
            if (Regex.IsMatch(match.Value, @"^\w+$")) // Word
            {
                words.Push(match.Value);
            }
            else // Non-word
            {
                nonWords.Enqueue(match.Value);
            }
        }

        string result = "";
        foreach (Match match in matches)
        {
            result += Regex.IsMatch(match.Value, @"^\w+$") ? words.Pop() : nonWords.Dequeue();
        }

        return result;
    
    }
}