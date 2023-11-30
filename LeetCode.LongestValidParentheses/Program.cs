using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace LeetCode.LongestValidParentheses
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.LongestValidParentheses(")))()())()");
        }
    }
    
    
    public class Solution {
        public int LongestValidParentheses(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            MyStack stack = new();
            stack.Push(-1);
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.IsEmpty())
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        int len = i - stack.Peek();
                        max = Math.Max(max, len);
                    }
                }
            }

            return max;
        }
        
    }

    class MyStack
    {
        private int[] Arr { get; set; }
        private int End { get; set; } = -1;
        public MyStack(int size = 10)
        {
            Arr = new int[size];
        }

        public void Push(int value)
        {
            End++;
            Arr[End] = value;
        }

        public int Pop()
        {
            var poppedValue = Arr[End];
            Arr[End] = default;
            End--;
            return poppedValue;
        }
        
        public int Peek()
        {
            if (End < 0)
            {
                return default;
            }
            return Arr[End];
        }

        public bool IsEmpty()
        {
            if (End != -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}