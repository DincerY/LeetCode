DiffSolution solution = new DiffSolution();
int[] nums = { 1, 1, 2 };
IList<IList<int>> result = solution.PermuteUnique(nums);

foreach (var list in result)
{
    Console.WriteLine(string.Join(", ", list));
}


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
        List<IList<int>> result = new List<IList<int>>();
        Dictionary<int, int> dictionary;
        foreach (var num in nums)
        {
            DictionaryUsage.AddDic(num);
        }
        dictionary = DictionaryUsage.DictionaryGet;

        void Recursion(List<int> onePermutation)
        {
            if (onePermutation.Count == nums.Length)
            {
                result.Add(new List<int>(onePermutation)); 
            }

            foreach (var key in dictionary.Keys)
            {
                if (dictionary[key] > 0)
                {
                    onePermutation.Add(key);
                    dictionary[key]--;
                    
                    Recursion(onePermutation);
                    
                    onePermutation.RemoveAt(onePermutation.Count-1);
                    dictionary[key]++;
                }
            }
        }
        Recursion(new List<int>());
        return result;

    }
}


//!!C# dan farklı bazı dillerde Dictionary veri yapına hashmap deniyor.
public class DictionaryUsage
{
    private static readonly Dictionary<int, int> _dictionary;
    public static Dictionary<int, int> DictionaryGet => _dictionary;

    static DictionaryUsage()
    {
        _dictionary = new Dictionary<int, int>();
    }
    public static void AddDic(int value)
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