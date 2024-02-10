Solution solution = new();
solution.CanJump(new[] { 2, 3, 1, 1, 4 });


Console.WriteLine("Hello, World!");



/// <summary>
/// Kaç atlama hakkım varsa hepsini küçükten başlayarak denicem ve kaydedicem
/// Recursive kullarak her atlama hakkımın içine ayrı ayrı girerek işlem yapıcam
/// Greedy olmasının sebebi üç kısımına gelince birden değilde en büyükten yani üçten devam etmek
/// üçten devam edilmediğinde de oluyor fakat Greedy algoritması en büyüğü kullanır.
/// </summary>
public class Solution {
    public bool CanJump(int[] nums)
    {
        int endIndex = nums.Length - 1;
        int canJump = nums[0];

        void Recursive(int index)
        {
            for (int i = 1; i <= nums[index]; i++)
            {
                Recursive(index++);
            }
        }
        
        Recursive(0);
        
        return true;
    }
}



