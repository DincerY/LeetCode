using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace LeetCode.MultiplyStrings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            // var a = solution.Multiply("123", "456");
            // solution.MultiplyUsingBigInteger("123","456");
            var a = solution.Multiply("123", "456");
            Console.WriteLine(a);
        }
    }

    public class Solution
    {
        public string Multiply1(string num1, string num2)
        {
            long intNum1 = 0;
            long intNum2 = 0;

            for (int i = 0; i < num1.Length; i++)
            {
                intNum1 += num1[i] - 48;
                if (i != num1.Length - 1)
                {
                    intNum1 *= 10;
                }
            }

            for (int i = 0; i < num2.Length; i++)
            {
                intNum2 += num2[i] - 48;
                if (i != num2.Length - 1)
                {
                    intNum2 *= 10;
                }
            }


            return (intNum1 * intNum2).ToString();
        }

        public string MultiplyUsingBigInteger(string num1, string num2)
        {
            BigInteger bigIntegerValue1 = BigInteger.Parse(num1);
            BigInteger bigIntegerValue2 = BigInteger.Parse(num2);

            BigInteger result = BigInteger.Multiply(bigIntegerValue1, bigIntegerValue2);
            return result.ToString();
        }

        public string Multiply2(string num1, string num2)
        {
            num1 = ReverseString(num1);
            num2 = ReverseString(num2);
            char[] charArr = new char[num2.Length + num1.Length];

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    int remain = 0;
                    int value = (num1[i] - 48) * (num2[j] - 48);
                    if (value > 9)
                    {
                        remain = value / 10;
                    }

                    if ((charArr[i + j] - 48) + value % 10 > 0)
                    {
                        remain = ((charArr[i + j] - 48) + value % 10) / 10;
                        charArr[i + j] = (char)((((charArr[i + j] - 48) + value % 10) % 10) + 48);
                    }
                    else
                    {
                        charArr[i + j] = (char)((value % 10) + 48);
                    }

                    if (remain > 0)
                    {
                        charArr[i + j + 1] = (char)(remain + 48);
                    }
                }
            }

            string resultValue = string.Join("", charArr);
            return ReverseString(resultValue);
        }

        private string ReverseString(string value)
        {
            Stack<char> stack = new Stack<char>();
            char[] charArr = new char[value.Length];

            for (int i = 0; i < value.Length; i++)
            {
                stack.Push(value[i]);
            }

            for (int i = 0; i < value.Length; i++)
            {
                charArr[i] = stack.Pop();
            }

            value = string.Join("", charArr);
            return value;
        }

        public char[] ToChar(int value)
        {
            int remain = 0;
            int mod = 0;
            if (value > 9)
            {
                remain = value / 10;
                mod = value % 10;
                return new[]
                {
                    (char)(remain + 48), (char)(mod + 48)
                };
            }
            else
            {
                return new[]
                {
                    (char)(value + 48)
                };
            }
        }


        public string Multiply(string num1, string num2)
        {
            int[] intArr = new int[num1.Length + num2.Length];

            num1 = new string(num1.Reverse().ToArray());
            num2 = new string(num2.Reverse().ToArray());

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {
                    intArr[i + j] += int.Parse(num1[i].ToString()) * int.Parse(num2[j].ToString());
                    intArr[i + j + 1] += intArr[i + j] / 10;
                    intArr[i + j] %= 10;
                }
            }

            int startIndex = intArr.Length - 1;
            while (startIndex > 0 && intArr[startIndex] == 0)
            {
                startIndex--;
            }

            return new string(intArr.Take(startIndex + 1).Select(x => (char)(x + 48)).Reverse().ToArray());
        }
    }
}