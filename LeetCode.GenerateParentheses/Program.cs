using System;
using System.Collections.Generic;

Solution solution = new();
var a = solution.GenerateParenthesis(3);
Console.WriteLine(a);

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        Stack<string> stack = new();
        List<string> res = new();

        void BackTrack(int openN, int closedN)
        {
            if (openN == closedN && openN == n)
            {
                res.Add(String.Join("", stack));
                return;
            }

            if (openN < n)
            {
                stack.Push(")"); //(
                BackTrack(openN + 1, closedN);
                stack.Pop();
            }

            if (closedN < openN)
            {
                stack.Push("("); //)
                BackTrack(openN, closedN + 1);
                stack.Pop();
            }
        }

        BackTrack(0, 0);
        return res;
    }
}
