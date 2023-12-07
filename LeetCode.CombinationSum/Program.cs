using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;

namespace LeetCode.CombinationSum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.CombinationSum(new []{2,3,5},8);

        }
    }


    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> res = new List<IList<int>>();

            void Recursive(int i,List<int> cur,int total)
            {
                if (total == target)
                {
                    res.Add(new List<int>(cur));
                    return;
                }
                
                if (i < candidates.Length)
                {
                    if (total + candidates[i] <= target)
                    {
                        cur.Add(candidates[i]);
                        Recursive(i,cur,total+candidates[i]);
                        cur.RemoveAt(cur.Count-1);
                    }
                    Recursive(i+1,cur,total);
                }
            }

            Recursive(0,new List<int>(),0);

            return res;
        }

        
        
    }
}