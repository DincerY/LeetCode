using System;
using System.Security.Permissions;

namespace RecursiveProblem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            //solution.Sum(5);
            solution.Fibonacci(6);
            solution.Factorial(5);

            Solution2 solution2 = new Solution2();
            int[] arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            solution2.WhileExample(arr);
            solution2.RecursionExample(arr,0);
            Console.WriteLine();
        }
    }

    public class Solution
    {
        public int Sum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            
            int a = Sum(n-1);

            return n + a;
        }

        public int Sum2(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else
            {
                return n + Sum2(n - 1);   
            }
        }

        public int Fibonacci(int n)
        {
            if (n>1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                return 1;
            }
        }

        public int Factorial(int n)
        {
            if (n > 1)
            {
                return n * Factorial(n-1);
            }

            return 1;
        }
    }

    public class Solution2
    {
        public void WhileExample(int[] arr)
        {
            int count = 0;
            while (count < arr.Length)
            {
                Console.WriteLine(arr[count]);
                count++;
            }
        }

        public void RecursionExample(int[] arr,int count)
        {
            if (count >= arr.Length)
            {
                return;
            }

            Console.WriteLine(arr[count]);
            
            RecursionExample(arr,count + 1);
            
            
        }
        
        
        
        
    }
    
    
}