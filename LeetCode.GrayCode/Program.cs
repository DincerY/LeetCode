using System.Collections;

Solution solution = new();
solution.GrayCode(2);



Console.WriteLine("Hello, World!");



public class Solution {
    public IList<int> GrayCode(int n)
    {
        int[] arr = new int[n]; 
        List<int[]> list = new();

        for (int i = 0; i < n*n; i++)
        {
            var result = arr.ToString();
            list.Add((int[])arr.Clone());
        }
        
        return null;
    }

}