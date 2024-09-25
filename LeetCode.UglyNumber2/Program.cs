Solution solution = new();
solution.NthUglyNumber2(10);
solution.NthUglyNumber(1);


Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution
{
    public int NthUglyNumber(int n)
    {
        var minHeap = new SortedSet<int>();
        minHeap.Add(1);
        var visit = new HashSet<int>();
        var factors = new int[] { 2, 3, 5 };

        for (int i = 0; i < n; i++)
        {
            int num = minHeap.Min;
            minHeap.Remove(num);
            if (i == n - 1)
            {
                return num;
            }

            foreach (var f in factors)
            {
                int newNum = num * f;
                if (!visit.Contains(newNum))
                {
                    visit.Add(newNum);
                    minHeap.Add(newNum);
                }
            }
        }

        return -1;
    }
}


public partial class Solution
{
    public int NthUglyNumber2(int n)
    {
        List<int> nums = new List<int> { 1 };
        int i2 = 0, i3 = 0, i5 = 0;

        for (int i = 1; i < n; i++)
        {
            int nextNum = Math.Min(Math.Min(nums[i2] * 2, nums[i3] * 3), nums[i5] * 5);
            nums.Add(nextNum);

            if (nextNum == nums[i2] * 2)
            {
                i2++;
            }

            if (nextNum == nums[i3] * 3)
            {
                i3++;
            }

            if (nextNum == nums[i5] * 5)
            {
                i5++;
            }
        }

        return nums[^1];
    }
}
