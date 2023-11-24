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
            solution.LongestValidParentheses("()(()");
        }
    }
    
    
    public class Solution {
        public int LongestValidParentheses(string s)
        {
            MyStack myStack = new MyStack(s.Length);
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' && s[i+1] == ')')
                {
                    myStack.Push(s[i]);
                } 
                if(myStack.Peek() != default)
                {
                    myStack.Pop();
                    count++;
                }
            
            }

            

            return count * 2;
        }
    }

    class MyStack
    {
        private char[] Arr { get; set; }
        private int End { get; set; } = -1;
        public MyStack(int size = 10)
        {
            Arr = new char[size];
        }

        public void Push(char value)
        {
            End++;
            Arr[End] = value;
        }

        public char Pop()
        {
            var poppedValue = Arr[End];
            Arr[End] = default;
            End--;
            return poppedValue;
        }
        
        public char Peek()
        {
            if (End < 0)
            {
                return default;
            }
            return Arr[End];
        }
    }
}