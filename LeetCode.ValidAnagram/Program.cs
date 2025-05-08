Solution solution = new();
solution.IsAnagram("anagram","nagaram");
solution.IsAnagram("rat","car");
solution.IsAnagram("a","ab");

Console.WriteLine("Hello, World!");


public partial class Solution {
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> dic = new();
        foreach (var chr in s)
        {
            if (dic.ContainsKey(chr))
            {
                dic[chr]++;
            }
            else
            {
                dic.Add(chr,1);
            }
        }

        foreach (var chr in t)
        {
            if (dic.ContainsKey(chr))
            {
                if (dic[chr] != 0)
                {
                    dic[chr]--;
                }
                if (dic[chr] == 0)
                {
                    dic.Remove(chr);
                }
            }
            else
            {
                return false;
            }
        }
        return dic.Count == 0;
    }
}