Solution solution = new();
solution.RangeBitwiseAnd2(1,3);

solution.RangeBitwiseAnd2(5,7);
solution.RangeBitwiseAnd2(0,0);
solution.RangeBitwiseAnd2(1,2147483647);

Console.WriteLine("Hello, World!");


//Is is not work
public partial class Solution {
    public int RangeBitwiseAnd(int left, int right)
    {
        if (left == 0 || right == 0)
        {
            return 0;
        }

        if (right == 1)
        {
            return 1;
        }

        var sqrt = (int)Math.Sqrt(left);
        var res = (int)Math.Pow(2,sqrt);
        int tempRes = res;
        for (int i = left + 1; i <= right;)
        {
            i = (int)Math.Pow(2,sqrt + 1);
            if (i <= right)
            {
                tempRes = i;
            }

            if (tempRes != res)
            {
                return 0;
            }
            sqrt++;
        }

        if (tempRes > res)
        {
            return 0;
        }
        return res;
    }
}
//Maybe use bit operator
public partial class Solution {
    public int RangeBitwiseAnd2(int left, int right)
    {
        var test = Convert.ToString(100, 2);
        for (int i = left; i <= right; i++)
        {
            Console.WriteLine(i >> 1);
        }
        var leftSqrt = (int)Math.Sqrt(left);
        int rightSqrt = (int)Math.Sqrt(right);
        if (leftSqrt != rightSqrt)
        {
            return 0;
        }

        if (leftSqrt == 0)
        {
            return 0;
        }
        return (int)Math.Pow(2, leftSqrt);

    }
}