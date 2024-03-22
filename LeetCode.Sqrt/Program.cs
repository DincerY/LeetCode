Solution solution = new();
solution.MySqrt(2147395600);
//2 147 483 647


Console.WriteLine("Hello, World!");





public class Solution {
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