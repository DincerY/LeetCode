Solution solution = new Solution();

// solution.SearchMatrix3(new[]
// {
//     new[] { 1, 3,5,7 },
//     new[] { 10, 11, 16, 20 },
//     new[] { 23, 30, 34,60 }
// }, 4);

solution.SearchMatrix2(new[]
{
    new[] { 1,3,4,5,7 }
}, 8);


Console.WriteLine("Hello, World!");


public partial class Solution
 {
     /// <summary>
     /// Brute Force
     /// </summary>
     /// <param name="matrix"></param>
     /// <param name="target"></param>
     /// <returns></returns>
     public bool SearchMatrix(int[][] matrix, int target)
     {
         for (int i = 0; i < matrix.Length; i++)
         {
             for (int j = 0; j < matrix[0].Length; j++)
             {
                 if (matrix[i][j] == target)
                 {
                     return true;
                 }
             }
         }
         return false;
     }
 }
public partial class Solution
{
    public bool SearchMatrix2(int[][] matrix, int target)
    {
        int left = 0;
        int right = matrix[0].Length - 1;
        for (int i = 0; i < matrix.Length; i++)
        {
            if (target <= matrix[i][^1])
            {
                //Binary
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (matrix[i][mid] > target)
                    {
                        right = mid -1;
                    }
                    else if(matrix[i][mid] < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        return true;
                    }
                }
                //Normal
                // for (int j = 0; j < matrix[0].Length; j++)
                // {
                //     if (matrix[i][j] == target)
                //     {
                //         return true;
                //     }
                // }
            }
            else
            {
                continue;
            }
        }
        return false;
    }
}

public partial class Solution
{
    /// <summary>
    /// Binary search
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool SearchMatrix3(int[][] matrix, int target)
    {
        //column x row = toplam uzunluk
        //toplam uzunluk / 2 = ortası
        //ortası < target -- toplam uzunluk = ortası
        //uzunluk kavramını index mantığına çevirmek için
        //uzunluk / column = hangi arrayda var olacağı
        //uzunluk % column = arrayın hangi indexinde var olacağı
        int column = matrix[0].Length;
        int lastIndex = matrix.Length * column;
        int firstIndex = 0;
        int stepCount = 0;
        int dd = (int)Math.Log2(lastIndex + firstIndex);
        while (stepCount <= dd)
        {
            int tempIndex = (lastIndex + firstIndex) / 2;
            if (matrix[tempIndex / column][tempIndex % column] > target)
                lastIndex = tempIndex;
            else if (matrix[tempIndex / column][tempIndex % column] < target)
                firstIndex = tempIndex;
            else
                return true;
            stepCount++;
        }
        return false;
    }
}











































 