Solution solution = new();
solution.IncreasingTriplet(new []{1, 2, 3, 4, 5});
solution.IncreasingTriplet(new []{2,1,5,0,4,6});


Console.WriteLine("Hello, World!");


public class Solution {
    public bool IncreasingTriplet(int[] nums)
    {
        int first = int.MaxValue;
        int second = int.MaxValue;

        foreach (var num in nums)
        {
            if (num <= first)
            {
                first = num;
            }
            else if (num <= second)
            {
                second = num;
            }
            else
            {
                return true;
            }
        }

        return false;
    }
}