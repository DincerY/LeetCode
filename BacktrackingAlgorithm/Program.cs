using System;
using System.Collections.Generic;

namespace BacktrackingAlgorithm
{
    class Program
    {
        
        static void Main()
        {
            Solution solution = new();
            solution.FindSubset(new []{1,2});
        }

       
    }

    class Solution
    {
        public void FindSubset(int[] arr)
        {
            BackTracking(0,arr,"");
        }

        void BackTracking(int index ,int[] arr,string b)
        {
            string a = b;
            for (int i = index; i < arr.Length; i++)
            {
                a = a + arr[i].ToString();
                Console.WriteLine(a);
                BackTracking(i+1,arr,arr[i].ToString());
                a = b;
            }

        }
    }
}