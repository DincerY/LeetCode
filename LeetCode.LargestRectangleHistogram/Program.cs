Solution solution = new();
// solution.LargestRectangleArea(new[]
// {
//     2, 1, 5, 6, 2, 3
// });

solution.LargestRectangleArea(new[]
{
    2, 1, 2
});


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int maxValue = 0;
        Stack<(int index, int value)> stack = new();
        stack.Push((0, heights[0]));
        for (int i = 1; i < heights.Length; i++)
        {
            (int index,int value) start = (0,0);
            while (stack.Count > 0 && heights[i] < stack.Peek().value)
            {
                start = stack.Pop();
                maxValue = Math.Max(maxValue, (i - start.index) * start.value);
            }
            if (heights[i] < start.value)
                stack.Push((start.index, heights[i]));
            else
                stack.Push((i, heights[i]));
        }
        while (stack.Count > 0)
        {
            var top = stack.Pop();
            maxValue = Math.Max(maxValue, (heights.Length - top.index) * top.value);
        }
        return maxValue;
    }
}