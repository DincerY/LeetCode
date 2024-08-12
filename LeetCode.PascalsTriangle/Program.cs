Solution solution = new Solution();
solution.Generate(5);


Console.WriteLine("Hello, World!");


public class Solution {
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> list = new();
        List<int> arr = new();
        if (numRows == 1)
        {
            arr.Add(numRows);
            list.Add(arr);
            return list;
        }
        arr.Add(1);
        int i = 0;
        while (i != numRows)
        {
            for (int j = 0; j < i; j++)
            {
                
            }

            i++;
            list.Add(arr.ToList());

        }
        
        
        
        
        return list;
    }
}