using System.Text.RegularExpressions;

Solution solution = new();
solution.IsPalindrome2("0P");
solution.IsPalindrome2("A man, a plan, a canal: Panama");
solution.IsPalindrome2("race a car");

Console.WriteLine("Hello, World!");


public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        var newStr = new string(s.Where(s => char.IsNumber(s) || char.IsLetter(s)).ToArray()).ToLower();
        var normal = newStr.ToArray();
        var reverse = newStr.Reverse().ToArray();
        
        for (int i = 0; i < normal.Length; i++)
        {
            if (normal[i] != reverse[i])
            {
                return false;
            }
        }
        return true;
    }
}

public partial class Solution
{
    public bool IsPalindrome2(string s)
    {
        string newString = new string(s.Where(c => char.IsLetter(c) || char.IsNumber(c)).ToArray()).ToLower();
        int i = 0;
        int j = newString.Length - 1;
        while (i < j)
        {
            if (newString[i] == newString[j])
            {
                i++;
                j--;
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}