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
            var a =solution.IsValid("){");
            Console.WriteLine(a);
        }
    }
    
    public class Solution {
        public bool IsValid(string s)
        {
            MyStack myStack = new();
            if (s.Length == 1)
            {
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    myStack.Push(s[i]);
                }
                else
                {
                    char bracket = WitchParentheses(myStack.Pop());
                    if (s[i] != bracket)
                    {
                        return false;
                    }
                }
            }

            if (myStack.GetLength() != -1)
            {
                return false;
            }
            return true;
        }

        private char WitchParentheses(char parentheses)
        {
            switch (parentheses)
            {
                case '{':
                    return '}';
                case '(':
                    return ')';
                case '[':
                    return ']';
                
            }

            return '\0';
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
            if (_top < 0)
            {
                return '\0';
            }
            char item = _elements[_top];
            //Equalize "top" to default and then top - 1;
            _elements[_top--] = default;

            return item;
        }

        public int GetLength()
        {
            return _top;
        }


    }
    
}
