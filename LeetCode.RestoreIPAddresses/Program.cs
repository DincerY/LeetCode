using System.Text;

Solution solution = new();
//solution.RestoreIpAddresses3("25525511135");
solution.RestoreIpAddresses("101023");

Console.WriteLine("Hello, World!");


public partial class Solution {
    public IList<string> RestoreIpAddresses(string s)
    {
        List<string> result = new();
        int dotSum = 0;
        if (s.Length > 12)
        {
            return null;
        }
        void Recursion(string[] sub,int n,int dot)
        {
            if (dotSum == s.Length)
            {
                Console.WriteLine("Başarılı");
                result.Add(string.Join(".",sub.ToString()));
            }

            sub[n] += s.Substring(dotSum, dot);
            
            dotSum += dot;
            
            if (n < 4)
            {
                Recursion(sub,n+1,1);
                dotSum-=1;
                Recursion(sub,n+1, 2);
                dotSum-=2;
                Recursion(sub,n+1 ,3);
                dotSum-=3;

            }
        }
        Recursion(new string[5],0,1);
        return null;
    }
}


//It is not mine solution
public partial class Solution {
    public IList<string> RestoreIpAddresses2(string s) {
        if (s.Length > 12)
            return new List<string>();

        var ans = new List<string>();
        for (int i = 0; i <= 3; i++)
        for (int j = 0; j <= 3; j++)
        for (int k = 0; k <= 3; k++)
        for (int l = 0; l <= 3; l++) {
            if (i + j + k + l != s.Length)
                continue;
                
            string part1 = s.Substring(0, i);
            string part2 = s.Substring(i, j);
            string part3 = s.Substring(i + j, k);
            string part4 = s.Substring(i + j + k, l);

            if (IsPartValid(part1) &&
                IsPartValid(part2) &&
                IsPartValid(part3) && 
                IsPartValid(part4)) {
                var res = part1 + "." + part2 + "." + part3 + "." + part4;
                ans.Add(res);
            }
        }

        return ans;
    }
    private bool IsPartValid(string part) {
        if (part == "")
            return false;

        if (part[0] == '0' && part.Length > 1) 
            return false;
        
        int num = int.Parse(part);
        if (num >= 0 && num <= 255)
            return true;

        return false;
    }
}

public partial class Solution {
    public IList<string> RestoreIpAddresses3(string s) {
        var ans = new List<string>();
        Permute(s, 0, new List<int>(), ans);
        return ans;         
    }
    
    private void Permute(string s, int startIndex, List<int> dots, List<string> ans) {
        int remainingLength = s.Length - startIndex;
        int remainingNumberOfIntegers = 4 - dots.Count;
        if (remainingLength > remainingNumberOfIntegers * 3 || 
            remainingLength < remainingNumberOfIntegers) {
            return;
        }
        if (dots.Count == 3) {
            if (IsValid(s, startIndex, remainingLength)) {
                StringBuilder sb = new StringBuilder();
                int last = 0;
                foreach (int dot in dots) {
                    sb.Append(s.Substring(last, dot));
                    last += dot;
                    sb.Append('.');
                }
                sb.Append(s.Substring(startIndex));
                ans.Add(sb.ToString());
            }
            return;
        }
        for (int curPos = 1; curPos <= 3 && curPos <= remainingLength; ++curPos) {
            // Append a dot at the current position.
            dots.Add(curPos);
            // Try making all combinations with the remaining string.
            if (IsValid(s, startIndex, curPos)) {
                Permute(s, startIndex + curPos, dots, ans);
            }
            // Backtrack, i.e. remove the dot to try placing it at the next position.
            dots.RemoveAt(dots.Count - 1);
        }
    } 

    private bool IsValid(string s, int start, int length) {
        return length == 1 || 
               (s[start] != '0' && 
                (length < 3 || 
                 s.Substring(start, length).CompareTo("255") <= 0));
    }     
}