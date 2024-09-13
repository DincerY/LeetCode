Solution solution = new();
//solution.FractionToDecimal(1, 2);
solution.FractionToDecimal(4, 333);
solution.FractionToDecimal(2, 1);

Console.WriteLine("Hello, World!");


//i did not solve it
public class Solution
{
    public string FractionToDecimal(int numerator, int denominator)
    {
        Dictionary<char,int> dic = new();
        double res = (double)numerator / denominator;
        var str = res.ToString();
        string[] arr = str.Split(",");
        if (arr.Length == 1)
        {
            return str;
        }
        string prevDot = arr[0];
        string afterDot = arr[1];
        for (int i = 0; i < afterDot.Length; i++)
        {
            dic.TryAdd(afterDot[i],i);
        }
       
        
        return "";
    }
}