namespace Assignment_02;
using System.Text.RegularExpressions;


public class PalindromesGet
{
    public static List<string> ExtractAndSortPalindromes(string text)
    {
        var words = Regex.Split(text, @"\W+");
        var palindromes = new HashSet<string>();

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        return palindromes.OrderBy(p => p).ToList();
    }
    
    private static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right]) return false;
            left++;
            right--;
        }

        return true;
    }
}