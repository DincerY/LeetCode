using System.Globalization;

Solution solution = new();
solution.LargestNumber(new[]
{
    3, 30, 34, 5, 9
});

solution.LargestNumber(new[]
{
    1000000000, 1000000000
});

Console.WriteLine("Hello, World!");

//it is not mine
//it is not worked
public class Solution
{
    public string LargestNumber(int[] arr)
    {
        if (arr.All(_ => _ == 0))
        {
            return "0";
        }

        string result;
        Array.Sort(arr, delegate(int num1, int num2)
        {
            return Convert.ToInt64(Convert.ToString(num2) + Convert.ToString(num1)).CompareTo(Convert.ToInt64(Convert.ToString(num1) + Convert.ToString(num2)));
        });
        result = string.Join("", arr);
        return result;
    }
}