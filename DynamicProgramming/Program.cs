using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.Fib(7);
        }
    }

    //Dynamic Programming With Memoization
    public class Solution
    {
        private Dictionary<int, int> _dic = new Dictionary<int, int>();
        public int Fib(int value)
        {
            if (value == 1 || value == 0)
            {
                return 1;
            }

            if (_dic.Keys.Contains(value))
            {
                return _dic[value];
            }
            _dic.Add(value,Fib(value - 1) + Fib(value - 2));
            return _dic[value];
        }
    }
}