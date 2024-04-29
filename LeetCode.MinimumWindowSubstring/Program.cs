Solution solution = new();
solution.MinWindow4("ADOBECODEBANC", "ABC");
//Console.WriteLine(solution.MinWindow("GDOBDCODEBAOD", "ABC"));
//Console.WriteLine(solution.MinWindow2("aa", "aa"));


Console.WriteLine("Hello, World!");


public partial class Solution
{
    /// <summary>
    /// It is not work
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public string MinWindow(string s, string t)
    {
        string resultString = "";
        Dictionary<char, int> dic = new();

        int leftPointer = 0;
        int count = 0;
        for (int i = 0; i < t.Length; i++)
        {
            dic.TryAdd(t[i], 0);
        }

        while (leftPointer <= s.Length - t.Length)
        {
            string tempString = "";
            if (!t.Any(c => c == s[leftPointer]))
            {
                leftPointer++;
                continue;
            }

            for (int i = leftPointer; i < s.Length; i++)
            {
                tempString += s[i];
                if (t.Any(c => c == s[i]))
                {
                    dic[s[i]]++;
                    count++;
                    if (count == 2)
                    {
                        leftPointer = i;
                    }
                }

                if (dic.All(t => t.Value >= 1))
                {
                    ResetDic(dic);
                    break;
                }
            }

            if (resultString == "")
            {
                resultString = tempString;
            }

            if (resultString.Length > tempString.Length)
            {
                resultString = tempString;
            }

            count = 0;
            tempString = "";
        }


        return resultString;
    }

    private void ResetDic(Dictionary<char, int> dic)
    {
        foreach (var key in dic.Keys)
        {
            dic[key] = 0;
        }
    }
}

public partial class Solution
{
    /// <summary>
    /// It is work and I tried to do
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public string MinWindow4(string s, string t)
    {
        int left = 0;
        int right = 0;
        int[] targetArr = new int[128];
        int requireElements = t.Length;
        int minLenght = int.MaxValue;
        int minStart = 0;

        foreach (var c in t)
        {
            targetArr[c]++;
        }

        while (right < s.Length)
        {
            if (targetArr[s[right++]]-- > 0)
            {
                requireElements--;
            }

            while (requireElements == 0)
            {
                if (right - left < minLenght)
                {
                    minLenght = right - left;
                    minStart = left;
                }

                if (targetArr[s[left++]]++ == 0)
                {
                    requireElements++;
                }
            }
        }

        return (minLenght == int.MaxValue) ? "" : s.Substring(minStart, minLenght);
    }
}