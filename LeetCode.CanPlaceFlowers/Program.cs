Solution solution = new();
solution.CanPlaceFlowers(new []{1,0,0,0,1}, 1);
solution.CanPlaceFlowers(new []{1,0,0,0,1}, 2);


Console.WriteLine("Hello, World!");

public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int tempN = n;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (i == 0)
            {
                if (flowerbed[i] != 1 && flowerbed[i+1] != 1)
                {
                    flowerbed[i] = 1;
                    tempN--;
                }
            }
            else if (i == flowerbed.Length - 1)
            {
                if (flowerbed[i] != 1 && flowerbed[i-1] != 1)
                {
                    flowerbed[i] = 1;
                    tempN--;
                }
            }
            else
            {
                
                if (flowerbed[i] != 1 && flowerbed[i+1] != 1 && flowerbed[i-1] != 1)
                {
                    flowerbed[i] = 1;
                    tempN--;
                }
            }
        }

        return tempN <= 0;
    }
}