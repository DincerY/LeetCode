Solution solution = new();
solution.CanCompleteCircuit(new []
{
    1,2,3,4,5
},new []
{
    3,4,5,1,2
});


Console.WriteLine("Hello, World!");


public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int startIdx = 0;
        int tank = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            if (gas[i] > cost[i])
            {
                startIdx = i;
                break;
            }
        }

        int j = 0;
        tank += gas[startIdx];
        startIdx++;
        while (j != startIdx)
        {
            if (startIdx >= gas.Length )
            {
                j = 0;
            }

            tank -= cost[startIdx];
            if (tank < 0)
            {
                break;
            }
            tank += gas[startIdx];

            j++;
        }
        return startIdx;
    }
}