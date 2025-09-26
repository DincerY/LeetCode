Solution solution = new();
solution.MaxVowels("a", 1);
solution.MaxVowels("abciiidef", 3);
solution.MaxVowels("ibpbhixfiouhdljnjfflpapptrxgcomvnb", 33);
Console.WriteLine("Hello, World!");

public class Solution
{
    public int MaxVowels(string s, int k)
    {
        List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
        int currentCount = 0;
        for (int i = 0; i < k; i++)
        {
            if (vowels.Contains(s[i]))
            {
                currentCount++;
            }
        }
        int maxCount = currentCount;
        for (int i = 0; i < s.Length - k; i++)
        {
            if (vowels.Contains(s[i]))
            {
                currentCount--;
            }

            if (vowels.Contains(s[i + k ]))
            {
                currentCount++;
            }

            maxCount = Math.Max(maxCount, currentCount);
        }
        return maxCount;
    }
}