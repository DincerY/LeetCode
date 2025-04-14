Solution solution = new();
solution.IsIsomorphic3("badc", "baba");

solution.IsIsomorphic2("a", "a");

solution.IsIsomorphic2("egg", "add");
solution.IsIsomorphic2("foo", "bar");
solution.IsIsomorphic2("paper", "title");

Console.WriteLine("Hello, World!");



public partial class Solution {
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, int> dicS = new();
        Dictionary<char, int> dicT = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (dicS.ContainsKey(s[i]))
            {
                dicS[s[i]]++;
            }
            else
            {
                dicS[s[i]] = 1;
            }
            if (dicT.ContainsKey(t[i]))
            {
                dicT[t[i]]++;
            }
            else
            {
                dicT[t[i]] = 1;
            }
        }
        foreach (var chr in dicS)
        {
            var list = dicT.FirstOrDefault(a => a.Value == chr.Value);
            dicT.Remove(list.Key);
            dicS.Remove(chr.Key);
        }
        if (dicT.Count == 0 && dicS.Count == 0)
        {
            return true;
        }
        return false;
    }
}

public partial class Solution {
    public bool IsIsomorphic2(string s, string t)
    {
        Dictionary<char, char> dic = new();
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsValue(t[i]))
            {
                continue;
            }
            if (!dic.ContainsKey(s[i]))
            {
                dic.Add(s[i],t[i]);
            }
        }
        string res = "";
        foreach (var chr in s)
        {
            if (!dic.ContainsKey(chr))
            {
                return false;
            }   
            res += dic[chr];

        }
        if (res == t)
        {
            return true;
        }
        return false;
    }
}

//NeedCode solution
public partial class Solution {
    public bool IsIsomorphic3(string s, string t) {
        Dictionary<char, char> mapST = new Dictionary<char, char>();
        Dictionary<char, char> mapTS = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++) {
            char c1 = s[i];
            char c2 = t[i];
            if ((mapST.ContainsKey(c1) && mapST[c1] != c2) || (mapTS.ContainsKey(c2) && mapTS[c2] != c1)) {
                return false;
            }
            mapST[c1] = c2;
            mapTS[c2] = c1;
        }
        return true;
    }
}