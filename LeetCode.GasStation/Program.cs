Solution solution = new();
solution.CanCompleteCircuit(new []
{
    1,2,3,4,5
},new []
{
    3,4,5,1,2
});


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        if (Sum(gas) < Sum(cost))
        {
            return -1;
        }
        
        int total = 0;
        int res = 0;
        
        for (int i = 0; i < gas.Length; i++)
        {
            total += (gas[i] - cost[i]);
            
            if (total < 0)
            {
                total = 0;
                res = i + 1;
            }
        }
        
        return res;
    }

    private int Sum(int[] array)
    {
        int sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum;
    }
}