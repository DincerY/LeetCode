Solution solution = new();
solution.IsAnagram("anagram","nagaram");
solution.IsAnagram("rat","car");

Console.WriteLine("Hello, World!");


public class Solution {
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
        }
        return dic.Count == 0;
    }
}