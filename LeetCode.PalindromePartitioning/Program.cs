Solution solution = new();
solution.Partition("aab");


Console.WriteLine("Hello, World!");


public class Solution {
    public IList<IList<string>> Partition(string s)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++)
            {
                list.Add(s.Substring(i, j - i));
            }
        }
        

        return null;
    }
}