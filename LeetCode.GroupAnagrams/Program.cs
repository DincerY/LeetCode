using System.Runtime.Serialization;

Solution solution = new();
solution.GroupAnagramsEx(new[] {"eat","tea","tan","ate","nat","bat"});

Console.WriteLine("Hello World!");


public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();
        List<IList<string>> result = new List<IList<string>>();
        foreach (var str in strs)
        {
            int total = 0;
            for (int i = 0; i < str.Length; i++)
            {
                total = total + (int)str[i];
            }
            if (!dictionary.ContainsKey(total))
            {
                dictionary[total] = new List<string>();
            }
            dictionary[total].Add(str);
        }

        foreach (var dic in dictionary)
        {
            result.Add(new List<string>(dic.Value));
        }

        return result;
    }


    public IList<IList<string>> GroupAnagramsEx(string[] strs)
    {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            int[] charValue = new int[26];
            foreach (var cha in str)
            {
                charValue[(cha - 'a')]++;
            }
            string key = string.Join(",", charValue);
            if (!anagramGroups.ContainsKey(key))
            {
                anagramGroups[key] = new List<string>();
            }
            anagramGroups[key].Add(str);
        }

        return new List<IList<string>>(anagramGroups.Values);
    }

    public IList<IList<string>> GroupAnagramsWithSort(string[] strs)
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            char[] charArry = str.ToCharArray();
            Array.Sort(charArry);
            string sortedString = new string(charArry);
            if (!dictionary.ContainsKey(sortedString))
            {
                dictionary[sortedString] = new List<string>();
            }
            dictionary[sortedString].Add(str);
        }
        
        return new List<IList<string>>(dictionary.Values);
   
    }
}