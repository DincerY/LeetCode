using System;
using System.Collections.Generic;

namespace LeetCode.CombinationSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.Recursive(1);
        }
    }
    
    
    public class Solution {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {

           




            return null;
        }

        public void Recursive(int[] candidates,int a)
        {
            if (a < 5)
            {
                Console.WriteLine(a);
                Recursive(candidates,a+1);
                Recursive(candidates,a+1);
            }
        }
        
    }
}