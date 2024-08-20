Solution solution = new();
solution.IsPalindrome("A man, a plan, a canal: Panama");
//solution.IsPalindrome("race a car");

Console.WriteLine("Hello, World!");


public class Solution
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