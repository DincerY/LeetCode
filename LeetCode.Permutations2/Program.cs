DiffSolution solution = new DiffSolution();
var result = solution.PermuteUnique(new []{1,1,2});
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

public class DiffSolution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        int numsLength = nums.Length;
        List<IList<int>> result = new List<IList<int>>();
        List<int> onePermutation = new List<int>();
            
        Dictionary<int, int> dictionary;
        DictionaryUsage usage = new DictionaryUsage();
        foreach (var n in nums)
        {
            usage.AddDic(n);
        }
        dictionary = usage.DictionaryGet;
        Recursion(numsLength,dictionary,onePermutation,result);
        return result;
    }
    
    private void Recursion(int length,Dictionary<int,int> nums,List<int> onePermutation,List<IList<int>> result)
    {
        if (onePermutation.Count == length)
        {
            
        }

        foreach (var kvp in nums)
        {
            for (int i = 0; i < kvp.Value; i++)
            {
                onePermutation.Add(kvp.Key);
            } 
        }
        
        //Recursion();    
    }
}


//!!C# dan farklı bazı dillerde Dictionary veri yapına hashmap deniyor.
public class DictionaryUsage
{
    private readonly Dictionary<int, int> _dictionary;
    public Dictionary<int, int> DictionaryGet => _dictionary;

    public DictionaryUsage()
    {
        _dictionary = new Dictionary<int, int>();
    }
    public void AddDic(int value)
    {
        if (_dictionary.ContainsKey(value))
        {
            _dictionary[value]++;
        }
        else
        {
            _dictionary.Add(value,1);
        }
    }
    public int GetSumAllValue()
    {
        int valueSum = 0;
        foreach (var value in _dictionary.Values)
        {
            valueSum += value;
        }
        return valueSum;
    }
    public void PrintDic()
    {
        foreach (var dic in _dictionary)
        {
            Console.WriteLine($"Sayı : {dic.Key}, Adeti : {dic.Value}");
        }
    }

  
}