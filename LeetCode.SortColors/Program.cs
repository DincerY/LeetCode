Solution solution = new();
solution.SortColors2(new[]
{
    2, 0, 2, 1, 1, 0,0,0
});


Console.WriteLine("Hello, World!");


public partial class Solution
{
    public void SortColors(int[] nums)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>()
        {
            {"0",0},
            {"1",0},
            {"2",0},
        };
        for (int i = 0; i < nums.Length; i++)
        {
            switch (nums[i])
            {
                case 0:
                    dic["0"]++;
                    break;
                case 1:
                    dic["1"]++;
                    break;
                case 2:
                    dic["2"]++;
                    break;
            }
            
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic["0"] > 0)
            {
                nums[i] = 0;
                dic["0"]--;
            }
            else if (dic["1"] > 0)
            {
                nums[i] = 1;
                dic["1"]--;
            }
            else
            {
                nums[i] = 2;
                dic["2"]--;
            }
        }
    }
}

public partial class Solution
{
    public void SortColors2(int[] nums)
    {
        int tempValue = 0;
        int left = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] == tempValue)
                {
                    (nums[left], nums[j]) = (nums[j],nums[left]);
                    left++;
                }
            }
            tempValue++;
        }
    }
}
