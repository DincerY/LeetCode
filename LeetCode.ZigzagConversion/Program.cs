using System;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Security.Permissions;
using System.Xml.Serialization;

namespace LeetCode.ZigzagConversion
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            var a =solution.Convert("samanlıkta", 5);
            Console.WriteLine(a);
            Console.Read();

        }

        
    }
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            string result = "";
            int increment = (numRows - 1) * 2;
            for (int i = 0; i < numRows; i++)
            {
                for (int j = i; j < s.Length; j+=increment)
                {
                    result += s[j];
                    if (i > 0 && i<numRows-1 && j + increment - 2 * i < s.Length)
                    {
                        result += s[j + increment - i * 2];
                    }
                }
            }

            return result;




            // if (numRows == 1)
            //     return s;
            //
            // string res = "";
            // for (int i = 0; i < numRows; i++)
            // {
            //     int increment = (numRows - 1) * 2;
            //     for (int j = i; j < s.Length; j+=increment)
            //     {
            //         res += s[j];
            //         if (i>0 && i< numRows - 1 && j +increment - 2 * i < s.Length)
            //         {
            //             res += s[j + increment - 2 * i];
            //         }
            //     }
            // }
            //
            // return res;
        }

        
    }
    
    
    
}

#region Deneme

// int i;
// int deneme = numRows + (numRows - 2);
// for (i = 0 ; i < numRows; i++)
// {
//     Console.Write(s[i]);
//     if (i!=0)
//     {
//         for (int j = 1; j < numRows-i; j++)
//         {
//             if (numRows-j == 2)
//             {
//                             
//             }
//             Console.Write(" ");
//                         
//         }
//
//         if (i != 4)
//         {
//             Console.Write(s[deneme-1]);
//             deneme--;
//         }
//     }
//                
//
//     Console.WriteLine();
//                 
//
// }

#endregion