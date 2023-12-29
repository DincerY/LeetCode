using System.Net.Security;

Solution solution = new();
int[] arr = new[] { 7,6,5,4,3,2,1 };
solution.FindKthLargest(arr, 2);
Console.WriteLine("Hello, World!");


public class Solution
{
    private int HeapSize { get; set; } = 1;
    private int Result { get; set; }
    private int[] Arrays { get; set; }
    
    private void Swap(int[] arr,int i,int j)    
    {
        (arr[i],arr[j]) = (arr[j],arr[i]);
    }

    private void HeapifyUp(int[] arr,int lastIndex)
    {
        int parent = lastIndex / 2;
        while (lastIndex > 1 && arr[parent] < arr[lastIndex])
        {
            Swap(arr,parent,lastIndex);
            lastIndex = parent;            
            parent = lastIndex / 2;
        }
    }

    private void HeapifyDown(int[] arr,int lastIndex)
    {
        int curr = 1;
        while (curr < lastIndex && arr[curr] < arr[curr * 2] || arr[curr] < arr[curr * 2 + 1])
        {
            int left = curr * 2;
            int right = curr * 2 + 1;

            if (arr[right] > arr[left])
            {
                Swap(arr,right,curr);
                curr = right;
            }
            else
            {
                Swap(arr,left,curr);
                curr = left;
            }

            if (curr >= lastIndex || curr == lastIndex-1)
            {
                break;
            }
        }
    }

    private void Insert(int value)
    {
        Arrays[HeapSize++] = value;
        HeapifyUp(Arrays,HeapSize-1);
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
        HeapifyDown(Arrays,HeapSize);
    }


    public int FindKthLargest(int[] nums, int k)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        Arrays = new int[nums.Length+1];
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