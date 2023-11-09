using System;
using System.Collections;
using System.Security.AccessControl;
using System.Security.Authentication.ExtendedProtection;

namespace LeetCode.ValidParentheses
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            solution.IsValid("");
        }
    }
    
    public class Solution {
        public bool IsValid(string s)
        {
            MyStack myStack = new();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    myStack.Push(s[i]);
                }
            }
            return true;
        }
    }


    public class MyStack
    {
        private const int DefaultSize = 10;
        private char[] _elements;
        private int _top = -1;

        public MyStack(int initialSize = DefaultSize)
        {
            _elements = new char[initialSize];
        }

        public void Push(char item)
        {
            _top++;
            _elements[_top] = item;
        }

        public char Pop()
        {
            char item = _elements[_top];
            //Equalize "top" to default and then top - 1;
            _elements[_top--] = default;

            return item;
        }


    }
    
}
