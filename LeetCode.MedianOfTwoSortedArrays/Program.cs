using System;
using System.Linq.Expressions;

namespace LeetCode.MedianOfTwoSortedArrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] arr1 = new[] { 1, 2 };
            int[] arr2 = new[] { 3,4 };
            double a = solution.FindMedianSortedArrays(arr1, arr2);
            Console.WriteLine(a);
        }
    }
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] newArr = new int[nums1.Length+nums2.Length];
            Merge(nums1,nums2,newArr);
            return FindMedianIndex(newArr);
        }

        public void Merge(int[] nums1, int[] nums2,int[] newArr)
        {
            int a = nums1.Length;
            int b = nums2.Length;
 
            int index = 0;
            int x = 0;
            int y = 0;
            while (x< a && y<b)
            {
                if ( nums1[x] < nums2[y])
                {
                    newArr[index] = nums1[x];
                    index++;
                    x++;
                }
                else
                {
                    newArr[index] = nums2[y];
                    index++;
                    y++;
                }
            }

            while (x<a)
            {
                newArr[index] = nums1[x];
                index++;
                x++;
            }
            
            while (y<b)
            {
                newArr[index] = nums2[y];
                index++;
                y++;
            }
        }

        public double FindMedianIndex(int[] arr)
        {
            int index;
            if (arr.Length % 2 ==0)
            {
                index = arr.Length / 2 -1;
                return (double)(arr[index] + arr[index + 1])/2;
            }
            else
            {
                index = arr.Length / 2 ;
                return arr[index];
            }
        }

       
    }
}
















