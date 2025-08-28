Solution solution = new();
solution.CanPlaceFlowers(new []{1,0,0,0,1}, 1);
solution.CanPlaceFlowers(new []{1,0,0,0,1}, 2);
solution.CanPlaceFlowers(new []{1,0,1,0,1,0,1}, 1);


Console.WriteLine("Hello, World!");

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int count = 0;
        int length = flowerbed.Length;

        for (int i = 0; i < length; i++)
        {
            if (flowerbed[i] == 0)
            {
                bool emptyLeft = i == 0 || flowerbed[i-1] == 0;
                bool emptyRight = i == length - 1 || flowerbed[i+1] == 0;
                if (emptyLeft && emptyRight)
                {
                    flowerbed[i] = 1;
                    count++;
                    if (count >= n)
                    {
                        return true;
                    }
                }
            }
        }
        return count >= n;
    }
}