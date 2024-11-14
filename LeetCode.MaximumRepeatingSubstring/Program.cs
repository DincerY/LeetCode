Solution solution = new();
solution.MaxRepeating("aaabaaaabaaabaaaabaaaabaaaabaaaaba", "aaaba");

Console.WriteLine("Hello, World!");


public class Solution
{
    public int MaxRepeating(string sequence, string word)
    {
        int count = 1;
        while (true)
        {
            string newWord = "";
            for (int i = 0; i < count; i++)
            {
                newWord = String.Concat(newWord,word);
            }
            if (!sequence.Contains(newWord))
            {
                return count - 1;
            }
            count++;
        }
    }
    
    
    public int MaxRepeating2(string sequence, string word)
    {
        int count = 0;
        String repeatedWord = word;
        while (sequence.Contains(repeatedWord))
        {
            count++;
            repeatedWord += word;
        }
        return count;
    }
}