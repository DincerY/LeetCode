Solution solution = new();
//solution.DeleteAndEarn(new[] { 3, 4, 2 });
//solution.DeleteAndEarn(new[] { 2, 2, 3, 3, 3, 4 });
//solution.DeleteAndEarn(new[] { 3,7,10,5,2,4,8,9,9,4,9,2,6,4,6,5,4,7,6,10 });

solution.DeleteAndEarn(new[] { 2, 3, 3, 5, 7, 7 });


Console.WriteLine("Hello, World!");

//NeedCode solution
public partial class Solution {
    public int DeleteAndEarn(int[] nums) {
        var count = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (count.ContainsKey(num)) {
                count[num]++;
            } else {
                count[num] = 1;
            }
        }

        var uniqueNums = count.Keys.ToList();
        uniqueNums.Sort();

        int earn1 = 0, earn2 = 0;
        for (int i = 0; i < uniqueNums.Count; i++) {
            int curEarn = uniqueNums[i] * count[uniqueNums[i]];

            if (i > 0 && uniqueNums[i] == uniqueNums[i - 1] + 1) {
                int temp = earn2;
                earn2 = Math.Max(curEarn + earn1, earn2);
                earn1 = temp;
            } else {
                int temp = earn2;
                earn2 = curEarn + earn2;
                earn1 = temp;
            }
        }
        return earn2;
    }
}



public partial class Solution
{
    public List<List<int>> combinations = new List<List<int>>();

    public void GenerateCombinations(int[] arr, int index, List<int> current)
    {
        if (index == arr.Length)
        {
            combinations.Add(current.ToList());
            return;
        }

        current.Add(arr[index]);
        GenerateCombinations(arr, index + 1, current);

        current.RemoveAt(current.Count - 1);

        GenerateCombinations(arr, index + 1, current);
    }
}