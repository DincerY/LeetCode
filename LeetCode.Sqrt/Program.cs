Solution solution = new();
//solution.MySqrt2(2147395599);
//2 147 483 647


Console.WriteLine(solution.MySqrt3(8));


public partial class Solution
{
    public int MySqrt(int x)
    {
        if (x >= 2147395600)
        {
            return 46340;
        }

        int i = 1;
        //List<int> list = new List<int>();
        while (true)
        {
            if (i * i > x)
            {
                break;
            }
            //list.Add(i);
            i++;
            int a =int.MaxValue;

        }

        if (i > 46340)
        {
            return 46340;
        }
        return i -1;
    }
}

public partial class Solution {
    public int MySqrt2(int x)
    {
        if (x == 0)
        {
            return 0;
        }
        int left = 0;
        int right = x - 1;
        int mid = right / 2;
        while (right - left != 1 && left < right)
        {
            if ((mid + 1) * (mid + 1) > x)
            {
                right = mid ;
            }
            else
            {
                left = mid;
            }

            mid = (left + right) / 2;
        }

        return left +1;
    }
}

/// <summary>
/// NeedCode solution
/// </summary>
public partial class Solution {
    public int MySqrt3(int x) {
        int res = 0;
        int l = 0;
        int r = x;
        while (l <= r) {
            int m = l + (r - l) / 2;
            if ((long)m * m == x) {
                return m;
            } else if ((long)m * m < x) {
                res = m;
                l = m + 1;
            } else {
                r = m - 1;
            }
        }
        return res;
    }
}