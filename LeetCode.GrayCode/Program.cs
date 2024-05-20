using System.Collections;

Solution solution = new();
solution.GrayCode(4);



Console.WriteLine("Hello, World!");



public class Solution {
    public IList<int> GrayCode(int n)
    {
        int[] arr = new int[n]; 
        List<int[]> list = new();

        for (int i = 0; i < n; i++)
        {
            list.Add(arr);
            AddOne(arr);
        }


        return null;
    }

    private void AddOne(int[] arr)
    {
        int remain = 0;
        arr[^1]++;
        for (int i = arr.Length-1; i >= 0;i--)
        {
            int temp = 0;
            if (arr[i] >= 2)
            {
                temp = arr[i];
                remain = temp / 2;
                temp = temp % 2;
            }
            if (remain == 0)
            {
                break;
            }

            arr[i] = temp;
            arr[i - 1] = remain;
            remain = 0;
        }
        
    }
}