using System.Numerics;

Solution solution = new();
solution.GcdOfStrings("ABCABC", "ABC");

Console.WriteLine("Hello, World!");

public class Solution {
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1)
        {
            return "";
        }

        var gdc = GCD(str1.Length, str2.Length);
        return str1.Substring(0,gdc);
    }
    // Euclidean algorithm
    private static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a | b;
    }
}