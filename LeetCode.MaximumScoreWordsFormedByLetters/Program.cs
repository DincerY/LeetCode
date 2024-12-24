Solution solution = new Solution();
solution.MaxScoreWords2(new string[] { "dog", "cat", "dad", "good" },
    new char[] { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' },
    new int[] { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
);


Console.WriteLine("Hello, World!");


public partial class Solution
{
    private Dictionary<char, int> dic = new Dictionary<char, int>();

    public int MaxScoreWords(string[] words, char[] letters, int[] score)
    {
        foreach (var c in letters)
        {
            if (dic.ContainsKey(c))
            {
                dic[c]++;
            }
            else
            {
                dic.Add(c, 1);
            }
        }

        void BackTracking(List<string> newList, int index)
        {
            if (index == words.Length)
            {
                foreach (var list in newList)
                {
                    Console.Write(list + " ");
                }

                Console.WriteLine();
                return;
            }


            var str = words[index];
            int i = 0;
            foreach (var chr in str)
            {
                if (dic.ContainsKey(chr))
                {
                    i++;
                }
            }

            if (i == str.Length)
            {
                foreach (var chr in str)
                {
                    if (dic.ContainsKey(chr))
                    {
                        dic[chr]--;
                    }
                }
            }

            newList.Add(words[index]);
            BackTracking(newList, index + 1);
            newList.RemoveAt(newList.Count - 1);
            BackTracking(newList, index + 1);
        }

        BackTracking(new List<string>(), 0);
        return 0;
    }
}

//NeedCode solution
public partial class Solution
{
    public int MaxScoreWords2(string[] words, char[] letters, int[] score)
    {
        Dictionary<char,int> letterCount = new Dictionary<char, int>();
        foreach (var letter in letters)
        {
            if (letterCount.ContainsKey(letter))
                letterCount[letter]++;
            else
                letterCount[letter] = 1;
        }

        bool CanFormWord(string word, Dictionary<char, int> letterCnt)
        {
            var wordCount = new Dictionary<char, int>();
            foreach (var c in word)
            {
                if (wordCount.ContainsKey(c))
                    wordCount[c]++;
                else
                    wordCount[c] = 1;
            }

            foreach (var c in wordCount.Keys)
            {
                if (wordCount[c] > letterCnt.GetValueOrDefault(c, 0))
                    return false;
            }

            return true;
        }

        int GetScore(string word)
        {
            int res = 0;
            foreach (var c in word)
            {
                res += score[c - 'a'];
            }

            return res;
        }

        int Backtrack(int i)
        {
            if (i == words.Length)
                return 0;

            int res = Backtrack(i + 1);

            if (CanFormWord(words[i], letterCount))
            {
                foreach (var c in words[i])
                {
                    letterCount[c]--;
                }

                res = Math.Max(res, GetScore(words[i]) + Backtrack(i + 1));
                foreach (var c in words[i])
                {
                    letterCount[c]++;
                }
            }

            return res;
        }

        return Backtrack(0);
    }
}