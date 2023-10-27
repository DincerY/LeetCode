using System;

namespace LeetCode.ZigzagConversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Deneme deneme = new Deneme();
            deneme.CreateZigzag();
            


        }

        class Deneme
        {
            public void CreateZigzag()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("*");

                    for (int j = 5 - i - 1; j > 0; j--)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("*");
                    Console.WriteLine();
                }
            }
        }
    }
}