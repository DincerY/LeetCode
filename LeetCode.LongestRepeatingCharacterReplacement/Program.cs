Solution solution = new();
solution.CharacterReplacement3("ABAB", 2);
solution.CharacterReplacement3("AABABBA", 1);

Console.WriteLine("Hello, World!");


public partial class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        
        int l = 0;
        int maxf = 0;
        int res = 0;
        for (int r = 0; r < s.Length; r++) {
            if (count.ContainsKey(s[r])) {
                count[s[r]]++;
            } else {
                count[s[r]] = 1;
            }
            maxf = Math.Max(maxf, count[s[r]]);

            if ((r - l + 1) - maxf > k) {
                count[s[l]]--;
                if (count[s[l]] == 0) {
                    count.Remove(s[l]);
                }
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }

        return res;
    }
}

public partial class Solution {
    public int CharacterReplacement2(string s, int k) {
        Dictionary<char, int> count = new Dictionary<char, int>();
        int res = 0;
        int l = 0;

        for (int r = 0; r < s.Length; r++) {
            if (count.ContainsKey(s[r])) {
                count[s[r]]++;
            } else {
                count[s[r]] = 1;
            }

            while ((r - l + 1) - Max(count.Values) > k) {
                count[s[l]]--;
                if (count[s[l]] == 0) {
                    count.Remove(s[l]);
                }
                l++;
            }
            res = Math.Max(res, r - l + 1);
        }

        return res;
    }

    private int Max(IEnumerable<int> values) {
        int max = int.MinValue;
        foreach (var value in values) {
            if (value > max) {
                max = value;
            }
        }
        return max;
    }
}

public partial class Solution {
    public int CharacterReplacement3(string s, int k)
    {
        int res = 0;
        Dictionary<char, int> dic = new();
        int l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            dic[s[r]] = 1 + (dic.ContainsKey(s[r]) ? dic[s[r]] : 0);

            while (r - l + 1 - dic.Max(s =>s.Value) > k)
            {
                dic[s[l]]--;
                l++;
            }

            res = Math.Max(res, r - l + 1);
        }
        return res;
    }
}