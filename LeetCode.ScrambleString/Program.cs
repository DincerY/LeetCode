using System.Runtime.Intrinsics.Arm;

Solution solution = new();
solution.IsScramble("great","rgeat");



Console.WriteLine("Hello, World!");










/// <summary>
/// It is not mine solution
/// </summary>
public class Solution {
    public bool Recursive(string s1, string s2)
    {
        if (s1.Length == 1)
            return s1 == s2;
        if (s1 == s2)
            return true;

        int n = s1.Length;

        for (int i = 1; i < n; i++)
        {
            if ((Recursive(s1.Substring(0,i),s2.Substring(0,i)) && 
                 Recursive(s1.Substring(i),s2.Substring(i)) || 
                 Recursive(s1.Substring(0,i),s2.Substring(n-i)) && 
                 Recursive(s1.Substring(i),s2.Substring(0,n-i))))
            {
                return true;
            }
        }
        return false;
    }

    public bool IsScramble(string s1, string s2)
    {
        int n = s1.Length;
        return Recursive(s1, s2);
    }
}