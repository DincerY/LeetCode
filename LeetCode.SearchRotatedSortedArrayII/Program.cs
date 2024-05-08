Solution solution = new();
// solution.Search(new[]
// {
//     2, 5, 6, 0, 0, 1, 2
// }, 3);

solution.Search(new[]
{
    2,2,2,3,2,2,2
}, 3);


Console.WriteLine("Hello, World!");


public class Solution
{
    public bool Search(int[] nums, int target)
    {
        //indexin kendisi ilk arrayın sonu iken indexin bir fazlası yeni arrayın başı
        int index = 0;
        while (index + 1 < nums.Length && nums[index] <= nums[index + 1])
        {
            index++;
        }

        if (nums.Length == 1)
        {
            return nums[0] == target ? true : false;
        }

        if (nums[0] < target)
        {
            return BinarySearch(nums, target, 0, index);
        }
        else
        {
            return BinarySearch(nums, target, index + 1, nums.Length - 1);
        }
    }

    private bool BinarySearch(int[] arr, int target, int low, int high)
    {
        int left = low;
        int right = high;
        while (left <= right)
        {
            int middle = (left + right) / 2;
            if (arr[middle]< target)
            {
                left = middle + 1;
            }
            else if (arr[middle] > target)
            {
                right = middle - 1;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}