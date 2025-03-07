Solution solution = new();
solution.CountSubstrings2("abc");
solution.CountSubstrings2("aaa");


Console.WriteLine("Hello, World!");

//NeedCode solution
 public partial class Solution
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

public partial class Solution
{
    public int CountSubstrings2(string s)
    {
        List<string> substrings = new List<string>();
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j <= s.Length; j++)
            {
                if (j-i == 0)
                {
                    continue;
                }
                substrings.Add(s.Substring(i,j-i));
            }
        }
        
        return Helper(substrings);
    }

    private int Helper(List<string> strs)
    {
        int count = 0;
        foreach (var str in strs)
        {
            if (isPalindrome(str))
            {
                count++;
            }
        }

        return count;
    }

    private bool isPalindrome(string str)
    {
        int first = 0;
        int last = str.Length - 1;
        while (first < last)
        {
            if (str[first] == str[last])
            {
                first++;
                last--;
            }
            else
            {
                break;
            }
        }
        return first >= last ? true : false;
    }
}

public partial class Solution
{
    //More effective than CountSubstrings2 
    public int CountSubstrings3(string s)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j <= s.Length; j++)
            {
                if (j-i == 0)
                {
                    continue;
                }
                if (isPalindrome(s.Substring(i,j-i)))
                {
                    count++;
                }
            }
        }
        return count;
    }
}

