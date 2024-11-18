using System;
using System.Collections.Generic;
using System.Linq;

Solution solution = new();
var a = solution.GenerateParenthesis(3);
Console.WriteLine(a);

public partial class Solution
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

//Kombinasyon mantığı
public partial class Solution
{
    private List<List<int>> res = new();
    private List<int> list = new List<int>() { 1, 2, 3 };

    public void Combination(int index, List<int> nums)
    {
        if (index == list.Count)
        {
            res.Add(nums.ToList());
            return;
        }
        var temp = nums.ToList();
        nums.Add(list[index]);
        Combination(index+1,nums);
        Combination(index+1,temp);
    }
}
