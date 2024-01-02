using System.Net.Security;

Solution solution = new();
int[] arr = new[] { 4,5,1,3,2};
var result = solution.FindKthLargest(arr, 3);
Console.WriteLine("Hello, World!");


public class Solution
{
    private int HeapSize { get; set; } = 1;
    private int Result { get; set; }
    private int[] Arrays { get; set; }

    private void Swap(int[] arr, int i, int j)
    {
        (arr[i], arr[j]) = (arr[j], arr[i]);
    }

    private void HeapifyUp(int[] arr, int lastIndex)
    {
        ;        int parent = lastIndex / 2;
        while (lastIndex > 1 && arr[parent] < arr[lastIndex])
        {
            Swap(arr, parent, lastIndex);
            lastIndex = parent;
            parent = lastIndex / 2;
        }
    }

    private void HeapifyDown(int[] arr, int lastIndex)
    {
        int curr = 1;
        int largestIndex = curr;
        while (true)
        {
            int left = largestIndex * 2;
            int right = largestIndex * 2 + 1;
            if (left <= lastIndex && arr[left] > arr[largestIndex])
            {
                largestIndex = left;
            }
            if (right <= lastIndex && arr[right] > arr[largestIndex])
            {
                largestIndex = right;
            }

            if (largestIndex == curr)
            {
                break;
            }
            Swap(arr,curr,largestIndex);
            curr = largestIndex;
        }
    }

    private void Insert(int value)
    {
        Arrays[HeapSize++] = value;
        HeapifyUp(Arrays, HeapSize - 1);
    }

    private void Remove()
    {
        Result = Arrays[1];
        Arrays[1] = Arrays[HeapSize];
        Arrays[HeapSize] = 0;
        HeapSize--;
        if (HeapSize <= 1)
        {
            return;
        }
        HeapifyDown(Arrays, HeapSize);
    }


    public int FindKthLargest(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        Arrays = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            Insert(nums[i]);
        }
        HeapSize--;
        for (int i = 0; i < k; i++)
        {
            Remove();
        }
        return Result;
    }
}