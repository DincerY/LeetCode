using System;

namespace LeetCode.DivideTwoIntegers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new();
            var a = solution.Divide(119, 10);
            Console.WriteLine();
        }
    }


    public class Solution
    {
        #region MySolution

        // public int Divide(int dividend, int divisor)
        // {
        //     int temp = dividend;
        //     int counter = 0;
        //
        //     if (temp - divisor < temp)
        //     {
        //         while (temp - divisor >= 0)
        //         {
        //             temp = temp - divisor;
        //             counter++;
        //         }
        //     }
        //
        //     else
        //     {
        //         while (temp + divisor >= 0)
        //         {
        //             temp = temp + divisor;
        //             counter--;
        //         }
        //     }
        //
        //     if (dividend < 0 && divisor > 0)
        //     {
        //         while (temp + divisor <= 0)
        //         {
        //             temp = temp + divisor;
        //             counter--;
        //         }
        //     }
        //
        //     if (dividend < 0 && divisor < 0)
        //     {
        //         while (temp - divisor <= 0)
        //         {
        //             temp = temp - divisor;
        //             counter++;
        //         }
        //     }
        //
        //
        //     return counter;
        // }

        #endregion
        
        
        
        
        //This is someone else's solution
        public int Divide(int dividend, int divisor)
        {
            // We can simply return if this is the case
            if (divisor == dividend) return 1;

            int result = 0;

            bool negativeResult = false;

            // Maintain the overflow so we can use it later...
            // Transform our negative values to positive ones and track whether our result will be negative as well.
            // If they share a sign, its positive, if they do not, it's negative.
            bool dividendOverflow = false, divisorOverflow = false;
            if (dividend < 0)
            {
                dividend = TwosComplement(dividend, out dividendOverflow);
                negativeResult = !negativeResult;
            }

            if (divisor < 0)
            {
                divisor = TwosComplement(divisor, out divisorOverflow);
                negativeResult = !negativeResult;
            }

            if (divisor > dividend || divisorOverflow)
            {
                // We checked if divisor and dividend were equal earlier
                // If we overflowed, then our divisor is definitely greater than our dividend.
                return 0;
            }

            // When we are doing our shifts, we can potentially overflow
            // Find out where our left-most bit is.
            // An 8-bit example:
            // 00010000>> 5 == 0000000, therefore we can shift it twice to the left
            // 00010000 << 3 == 1000000, which is negative.
            int maxShift = 0;
            for (int i = 0; i < 31; i++)
            {
                if (divisor >> i > 0)
                {
                    maxShift = 31 - i;
                }
                else
                {
                    break;
                }
            }

            // Now we will convert our division operation into a sum of powers of two
            // Shifting to the left by i is the same as multiplying our divisor by 2^i
            // an example 15 / 3
            // 3 << 3 == 24; 24 > 15
            // 3 << 2 == 12; 12 < 15; result += 2^2 => 4; dividend -= 12 => 3
            // 3 << 1 == 6; 6 > 3
            // 3 << 0 == 3; 3 <= 3; result += 2^0 => 5; dividend -= 3 => 0
            // Answer is 5, remainder is 0
            for (int i = maxShift; i >= 0; i--)
            {
                int shift = divisor << i;
                if (shift < 0) continue;

                if (shift <= dividend)
                {
                    dividend -= shift;
                    result += 1 << i;
                }
            }

            int remainder = dividend;

            // If our dividend had overflow (because our input is int.MinValue)
            // We need to check whether the overflowed value would have added to our result
            // This happens if our remainder is 1 less than our divisor
            // If it is, then we add 1 to our result.
            // We can't yet, though, we have to handle the negative result first to handle our boundary conditions
            bool addToResult = dividendOverflow && (remainder + 1) >= divisor;

            if (negativeResult)
            {
                // If our result should be negative, invert the value
                bool resultOverflow;
                result = TwosComplement(result, out resultOverflow);
                // Subtract from our negative result due to overflow
                if (addToResult && result > int.MinValue)
                {
                    result -= 1;
                }
            }
            else if (addToResult && result < int.MaxValue)
            {
                // Add to our positive result due to overflow
                result += 1;
            }

            return result;
        }

        public int TwosComplement(int digit, out bool hadOverflow)
        {
            // Twos complement is invert bits then add 1
            var invert = ~digit;
            if (invert == int.MaxValue)
            {
                // We've inverted our bits but the next step is to add 1...
                // If we are at the maximum integer value, then we can't add 1. Keep this for later.
                hadOverflow = true;
                return invert;
            }
            else
            {
                hadOverflow = false;
                return invert + 1;
            }
        }
    }
}