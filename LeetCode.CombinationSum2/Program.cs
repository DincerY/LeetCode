using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace LeetCode.CombinationSum2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a =solution.CombinationSum2(new[] { 10,1,2,7,6,1,5}, 8);
                                                                         //1,1,2,5,6,7,10
            Console.WriteLine();

        }
    }

    public class Solution {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            List<IList<int>> res = new();
            void Recursion(List<int> cur,int pos,int reTarget)
            {
                if (reTarget == 0)
                {
                    res.Add(new List<int>(cur));
                }
                if (reTarget <= 0)
                {
                    return;
                }
                int prev = -1;
                for (int i = pos; i < candidates.Length; i++)
                {
                    if (candidates[i] == prev)
                    {
                        continue;
                    }
                    cur.Add(candidates[i]);
                    Recursion(cur,i+1,reTarget-candidates[i]);
                    cur.RemoveAt(cur.Count-1);
                    prev = candidates[i];
                }
            }
            Recursion(new List<int>(),0,target);
            return res;
        }
        
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}