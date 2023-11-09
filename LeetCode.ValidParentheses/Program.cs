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
        private const int DEFAULT_SIZE = 10;
        private string[] elements;
        private int top = -1;

        public MyStack(int initialSize = DEFAULT_SIZE)
        {
            elements = new string[initialSize];
        }

        public void Push(string item)
        {
            top++;
            elements[top] = item;
        }

        public string Pop()
        {
            string item = elements[top];
            //Equalize "top" to default and then top - 1;
            elements[top--] = default;

            return item;
        }


    }
    
}
