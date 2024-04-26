Solution solution = new();
 solution.MinWindow4("ADOBECODEBANC", "ABC");
//Console.WriteLine(solution.MinWindow("GDOBDCODEBAOD", "ABC"));
//Console.WriteLine(solution.MinWindow2("aa", "aa"));




Console.WriteLine("Hello, World!");



public partial class Solution {
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

    private void ResetDic(Dictionary<char,int> dic)
    {
        foreach (var key in dic.Keys)
        {
            dic[key] = 0;
        }
    }
}


public partial class Solution {
    /// <summary>
    /// It is not my solution
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public string MinWindow2(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) {
            return "";
        }

        int[] targetCount = new int[128]; // Assuming ASCII characters

        foreach (char c in t) {
            targetCount[c]++;
        }

        int left = 0, right = 0;
        int minLen = int.MaxValue;
        int minStart = 0;
        int requiredChars = t.Length;

        while (right < s.Length) {
            if (targetCount[s[right++]]-- > 0) {
                requiredChars--;
            }

            while (requiredChars == 0) {
                if (right - left < minLen) {
                    minLen = right - left;
                    minStart = left;
                }

                if (targetCount[s[left++]]++ == 0) {
                    requiredChars++;
                }
            }
        }

        return (minLen == int.MaxValue) ? "" : s.Substring(minStart, minLen);
    }
    
   
}

public partial class Solution
{
    /// <summary>
    /// It is not my solution
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    public string MinWindow3(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length < t.Length)
        {
            return "";
        }

        int[] map = new int[128];
        int count = t.Length;
        int start = 0, end = 0, minLen = int.MaxValue, startIndex = 0;
        /// UPVOTE !
        foreach (char c in t)
        {
            map[c]++;
        }

        char[] chS = s.ToCharArray();

        while (end < chS.Length)
        {
            if (map[chS[end++]]-- > 0)
            {
                count--;
            }

            while (count == 0)
            {
                if (end - start < minLen)
                {
                    startIndex = start;
                    minLen = end - start;
                }

                if (map[chS[start++]]++ == 0)
                {
                    count++;
                }
            }
        }

        return minLen == int.MaxValue ? "" : new string(chS, startIndex, minLen);
    }
}



public partial class Solution {

    public string MinWindow4(string s, string t)
    {
        int left = 0;
        int right = 0;
        int[] targetArr = new int[128];
        int requireElement = t.Length;

        foreach (var c in t)
        {
            targetArr[c]++;
        }

        while (right < s.Length)
        {
            
        }
        
        
        
        
        
        return "";
    }
    
}
