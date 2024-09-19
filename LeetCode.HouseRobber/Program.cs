Solution solution = new();
solution.Rob(new []
{
    2,7,9,3,1
});

solution.Rob(new []
{
    2,1,1,2
});

Console.WriteLine("Hello, World!");

//NeedCode solution
public class Solution
{
    public int Rob(int[] nums)
    {
        int rob1 = 0;
        int rob2 = 0;
        foreach (var n in nums)
        {
            int temp = Math.Max(n + rob1, rob2);
            rob1 = rob2;
            rob2 = temp;
        }
        return rob2;
    }
}