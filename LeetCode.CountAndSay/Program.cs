using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.CountAndSay
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.CountAndSay(4);
        }
    }

    public class Solution
    {
        public string CountAndSay(int n)
        {
            string bb = "1";
            n--;
            if (n > 1)
            {
                bb = CountAndSay(n);
            }

            return Helper(Helper(bb));
            
        }
        
        private List<int[]> Helper(string n)
        {
            List<int[]> sub = new List<int[]>();
            char prev = n[0];
            int prevCount = 1;

            for (int i = 0; i < n.Length; i++)
            {
                int j = i;
                int prevJ = j;
                while (j < n.Length && n[i] == n[j])
                {
                    j++;
                }
                sub.Add(new []{n[i]-48,j-prevJ});
                i = j - 1;
            }
            
            return sub;
        }

        private string Helper(List<int[]> sub)
        {
            StringBuilder builder = new();
            foreach (var intArr in sub)
            {
                for (int i = 1; i >= 0; i--)
                {
                    builder.Append(intArr[i]);
                }
            }
            return builder.ToString();
        }
    }
}