Solution solution = new();
solution.GroupAnagramsEx(new[] { "cab","tin","pew","duh","may","ill","buy","bar","max","doc" });


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

    /// <summary>
    /// Bir sonraki çalışmada verilen dizi içerisindeki yapıların hepsini alfabetik sıralayacağım ardından
    /// karşılaştırma yapacağım.
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public IList<IList<string>> GroupAnagramsWithSort(string[] strs)
    {
        string ornekString = "merhaba";

        // String'i bir karakter dizisine çevir
        char[] charArray = ornekString.ToCharArray();

        // Karakter dizisini alfabetik olarak sırala
        Array.Sort(charArray);

        // Sıralanmış karakter dizisini tekrar stringe çevir
        string siraliString = new string(charArray);

        // Sonucu ekrana yazdır
        Console.WriteLine("Orijinal String: " + ornekString);
        Console.WriteLine("Sıralı String: " + siraliString);


        return null;
    }
}