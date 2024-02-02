using System.Threading.Channels;

Solution solution = new Solution();
var result = solution.MaxSubArray2(new[] {-2,1,-3,4,-1,2,1,-5,4});
Console.WriteLine(result);

Console.WriteLine("Hello, World!");



public partial class Solution {
    public int MaxSubArray(int[] nums)
    {
        List<List<int>> list = new();
        for (int i = 0; i < nums.Length; i++)
        {
            var value = new List<int>(){nums[i]};
            list.Add(new List<int>(value));
            for (int j = i + 1; j < nums.Length; j++)
            {
                value.Add(nums[j]);
                list.Add(new List<int>(value));
            }
        }
        var total = Int32.MinValue;

        foreach (var lis in list)
        {
            var newTotal = Sum(lis);
            if (newTotal > total)
            {
                total = newTotal;
            }
        }

        return total;
    }


    private int Sum(List<int> arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            sum += arr[i];
        }

        return sum;
    }
}


public partial class Solution
{
    /// <summary>
    /// Baştaki eksileri zaten silicez onun haricinde yan yana iki sayının toplamı eklenecek sayıdan küçükse
    /// yan yana olan sayıları atlıcaz ve eklenecek sayıdan devam edicez hem yeni bir array oluşturmucaz hemde
    /// zaman karmaşıklığımız lineer olucak.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int MaxSubArray2(int[] nums)
    {
        
        
        
        
        return 0;
    }
    
}











