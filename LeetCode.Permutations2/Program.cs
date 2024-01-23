Solution solution = new Solution();
var result = solution.PermuteUnique(new []{1,2,3});
Console.WriteLine(result);


public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        List<int> onePermutation = new List<int>();

        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        Recursion(nums, dictionary, result);

        result = RemoveDuplicateLists(result);

        return result;
    }
    
    private void Recursion(int[] nums,Dictionary<int,int> dictionary,List<IList<int>> result)
    {  
        if (dictionary.Count == nums.Length)
        {
            result.Add(new List<int>(dictionary.Values));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (dictionary.Keys.Contains(i)) continue;
            dictionary.Add(i,nums[i]);
            Recursion(nums,dictionary,result);
            dictionary.Remove(i);
        }
    }
    private List<IList<int>> RemoveDuplicateLists(List<IList<int>> listOfLists)
    {
        HashSet<string> set = new HashSet<string>();
        List<IList<int>> result = new List<IList<int>>();

        foreach (var subList in listOfLists)
        {
            // Listeyi string'e çevirerek HashSet içinde kontrol et
            string listAsString = string.Join(",", subList);
            if (set.Add(listAsString))
            {
                result.Add(subList);
            }
        }
        return result;
    }

    
  
}