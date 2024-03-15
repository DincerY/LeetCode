﻿Solution solution = new();
solution.AddBinary("10001", "11");


Console.WriteLine("Hello, World!");


public class Solution
{
   
    public string AddBinary(string a, string b) {
        string res = "";
        int carry = 0;
        for (int i = 0; i < Math.Max(a.Length, b.Length); i++) {
            int digitA = i < a.Length ? (int)(a[i] - '0') : 0;
            int digitB = i < b.Length ? (int)(b[i] - '0') : 0;
            int total = digitA + digitB + carry;
            res = (total % 2).ToString() + res;
            carry = total / 2;
        }
        if (carry > 0)
            res = "1" + res;
        return res;
    }

    public string SumChar(string a, string b)
    {
        for (int i = 0; i < Math.Max(a.Length,b.Length); i++)
        {
            
        }

        return "";
    }
}