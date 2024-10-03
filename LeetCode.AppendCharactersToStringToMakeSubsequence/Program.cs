Solution solution = new();
solution.AppendCharacters("coaching", "coding");

Console.WriteLine("Hello, World!");

public class Solution
{
    public int AppendCharacters(string s, string t)
    {
        int j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (j >= t.Length)
            {
                break;
            }
            if (s[i] == t[j])
            {
                j++;
            }
        }
        return t.Length - j;
    }
}