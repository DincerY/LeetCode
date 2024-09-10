using System.Text;

Solution solution = new Solution();
solution.ReverseWords("the sky is blue");
//solution.ReverseWords("  hello world  ");


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public string ReverseWords(string s)
    {
        List<string> list = new();
        string val = "";
        foreach (var chr in s)
        {
            if (chr != ' ')
            {
                val += chr;
            }
            else
            {
                if (val == "")
                {
                    continue;
                }
                list.Add(val);
                val = "";
            }
        }
        if (val != "")
        {
            list.Add(val);
            val = "";
        }
        list.Reverse();
        val = string.Join(" ", list);
        
        return val;
    }
}

//Different solution
public partial class Solution {
    public string ReverseWords2(string s)
    {
        string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
