Solution solution = new();
solution.CheckInclusion2("ab", "eidboaoo");
solution.CheckInclusion2("adc", "dcda");

Console.WriteLine("Hello, World!");

//Time limit exceeded
public partial class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> dic = new();
        for (int i = 0; i < s1.Length; i++)
        {
            dic[s1[i]] = 1 + (dic.ContainsKey(s1[i]) ? dic[s1[i]] : 0);
        }

        int r = 0;
        for (int l = 0; l < s2.Length; l++)
        {
            if (dic.ContainsKey(s2[l]))
            {
                r = l;
                while (r < s2.Length && dic.ContainsKey(s2[r]))
                {
                    dic[s2[r]]--;
                    if (dic[s2[r]] == 0)
                    {
                        dic.Remove(s2[r]);
                    }
                    r++;
                }
            }

            if (dic.Count == 0)
            {
                return true;
            }

            var tempL = l;
            while (r - tempL > 0)
            {
                dic[s2[tempL]] = 1 + (dic.ContainsKey(s2[tempL]) ? dic[s2[tempL]] : 0);
                tempL++;
            }
        }

        return false;
    }
}

public partial class Solution
{
    public bool CheckInclusion2(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        int[] s1Count = new int[26];
        int[] s2Count = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }

        int matches = 0;
        for (int i = 0; i < 26; i++)
        {
            if (s1Count[i] == s2Count[i])
            {
                matches++;
            }
        }

        int l = 0;
        for (int r = s1.Length; r < s2.Length; r++)
        {
            if (matches == 26)
            {
                return true;
            }

            int index = s2[r] - 'a';
            s2Count[index]++;
            if (s1Count[index] == s2Count[index])
            {
                matches++;
            }
            else if (s1Count[index] + 1 == s2Count[index])
            {
                matches--;
            }

            index = s2[l] - 'a';
            s2Count[index]--;
            if (s1Count[index] == s2Count[index])
            {
                matches++;
            }
            else if (s1Count[index] - 1 == s2Count[index])
            {
                matches--;
            }

            l++;
        }

        return matches == 26;
    }
}