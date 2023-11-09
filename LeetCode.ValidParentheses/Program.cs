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
            myStack.Push("a");
            myStack.Push("b");
            myStack.Push("c");
            myStack.Push("d");
            myStack.Push("e");
            myStack.Push("f");
            myStack.Push("g");

            return true;
        }
    }


    public class MyStack
    {
        private const int DefaultSize = 10;
        private string[] _elements;
        private int _top = -1;

        public MyStack(int initialSize = DefaultSize)
        {
            _elements = new string[initialSize];
        }

        public void Push(string item)
        {
            _top++;
            _elements[_top] = item;
        }

        public string Pop()
        {
            string item = _elements[_top];
            //Equalize "top" to default and then top - 1;
            _elements[_top--] = default;

            return item;
        }


    }
    
}
