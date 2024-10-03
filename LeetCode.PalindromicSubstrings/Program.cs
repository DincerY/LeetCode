Solution solution = new();
solution.CountSubstrings("abc");
solution.CountSubstrings("aaa");


Console.WriteLine("Hello, World!");

//NeedCode solution
public class Solution
{
    public int CountSubstrings(string s)
    {
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            res += countPali(s, i, i);
            res += countPali(s, i, i + 1);
        }

        return res;
    }

    private int countPali(string s, int l, int r)
    {
        int res = 0;
        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            res += 1;
            l -= 1;
            r += 1;
        }

        return res;
    }
}
