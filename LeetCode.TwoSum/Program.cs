using System;
using System.Collections;
using System.Collections.Generic;



namespace LeetCode.TwoSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution3 s = new Solution3();
            int[] arr = new int[] {1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1 };
            int[] twoSum = s.TwoSum(arr, 11);

            foreach (var i in twoSum)
            {
                Console.Write($"{i}-");
                
                
            }
        }
        
        
    }
    
    public class Solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] {i, j };
                    }
                }
            }
            throw new ArgumentException("");
        }
    }

    public class Solution2
    {
        public Dictionary<int, int> IntDictionary = new Dictionary<int, int>();
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (IntDictionary.ContainsKey(difference))
                {
                    return new int[] { IntDictionary[difference], i};
                }

                if (!IntDictionary.ContainsKey(nums[i]))
                {
                    IntDictionary.Add(nums[i],i);
                }
            }

            return new[] { -1, -1 };
        }
    }

    public class Solution3
    {
        private Hashtable _hashtable = new Hashtable();
        public int[] TwoSum(int[] nums, int target)
        {
      
            for (int i = 0; i < nums.Length; i++)
            {
                int difference = target - nums[i];
                if (_hashtable.ContainsKey(difference))
                {
                    return new int[] { (int)_hashtable[difference], i};
                }

                if (!_hashtable.ContainsKey(nums[i]))
                {
                    _hashtable.Add(nums[i],i);
                }
                
            }

            return new[] { -1, -1 };
        }
    }
    
    
    
    


}


