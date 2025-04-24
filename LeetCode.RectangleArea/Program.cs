Solution solution = new();
solution.ComputeArea(-3, 0, 3, 4, 0, -1, 9, 2);

Console.WriteLine("Hello, World!");


public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        int ax = Math.Abs(ax1 - ax2);
        int ay = Math.Abs(ay1 - ay2);
        int bx = Math.Abs(bx1 - bx2);
        int by = Math.Abs(by1 - by2);

        var total = ax * ay + bx * by;
        var yDiff = Math.Abs(ay1 - by2);
        var xDiff = Math.Abs(bx1 - ax2);
        total -= yDiff * xDiff;
        return total;
    }
}