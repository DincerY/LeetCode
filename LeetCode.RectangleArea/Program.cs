Solution solution = new();
solution.ComputeArea(0, 0, 0, 0, -1, -1, 1, 1);

solution.ComputeArea(-3, 0, 3, 4, 0, -1, 9, 2);

Console.WriteLine("Hello, World!");


public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        int x = Math.Min(ax2, bx2) - Math.Max(ax1, bx1);
        int y = Math.Min(ay2, by2) - Math.Max(ay1 , by1);
        int dif = x * y;
        if (x <= 0 || y <= 0)
        {
            dif = 0;
        }

        int area(int x1, int x2, int y1,int y2)
        {
            return (x2 - x1) * (y2 - y1);
        }

        return area(ax1, ax2, ay1, ay2) + area(bx1, bx2, by1, by2) - dif;
    }
}