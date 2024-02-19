Solution solution = new();
var boolDeneme = solution.CanJump(new[] { 2, 3, 1, 1, 4 });



Console.WriteLine("Hello, World!");


/// <summary>
/// Bu sefer index düşünerek yazalım.
/// CanJump değişkeni recursive içinde değişip yeni değerini almalı
/// </summary>
public class Solution
{
    public bool CanJump(int[] nums)
    {
        int endIndex = nums.Length - 1;
        int canJump = nums[0];

        void Recursive(int index)
        {
            if (index == endIndex)
            {
                return; 
            }
            canJump = nums[index];
            for (int i = 1; i <= canJump; i++)
            {
                Recursive(index + i);
            }
        }

        Recursive(0);

        return true;
    }
}