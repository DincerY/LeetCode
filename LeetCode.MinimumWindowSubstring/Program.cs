Solution solution = new();
// solution.MinWindow("ADOBECODEBANC", "ABC");
solution.MinWindow("GDOBACODEBANC", "ABC");



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
        //bu değişken s nin içinde ki bir diğer t değişkeninin başlagıç indexinin tutucak
        int leftPointer = 0;
        int count = 0;
        for (int i = 0; i < t.Length; i++)
        {
            dic.Add(t[i],0);
        }
        while (leftPointer < s.Length - t.Length)
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

    public string MinWindow2(string s, string t)
    {
        return "";
    }
}