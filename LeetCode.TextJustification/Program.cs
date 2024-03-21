Solution solution = new();
// solution.FullJustify(new[]
// {
//     "This", "is", "an", "example", "of", "text", "justification."
// }, 16);

// solution.FullJustify(new[]
// {
//     "What","must","be","acknowledgment","shall","be"
// }, 16);

solution.FullJustify(new[]
{
    "Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"
}, 20);


Console.WriteLine("Hello, World!");




public partial class Solution
{
    /// <summary>
    /// NeedCode Solution In YouTube
    /// </summary>
    /// <param name="words"></param>
    /// <param name="maxWidth"></param>
    /// <returns></returns>
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> result = new List<string>();
        List<string> line = new List<string>();
        int length = 0;
        int i = 0;
        while (i < words.Length)
        {
            if (length + line.Count + words[i].Length <= maxWidth)
            {
                line.Add(words[i]);
                length += words[i].Length;
                i++;
            }
            else
            {
                int extraSpace = maxWidth - length;
                int spaces = line.Count - 1 > 0 ? extraSpace / (line.Count - 1) : extraSpace;
                int remainder = line.Count - 1 > 0 ? extraSpace % (line.Count - 1) : 0;
                string lineString = "";

                for (int j = 0; j < line.Count; j++)
                {
                    lineString += line[j];
                    if (j < line.Count - 1)
                    {
                        lineString += new string(' ', spaces);
                        if (remainder > 0)
                        {
                            lineString += " ";
                            remainder--;
                        }
                    }
                }

                result.Add(lineString.PadRight(maxWidth));

                line.Clear();
                length = 0;
            }
        }

        if (line.Count > 0)
        {
            string lastLine = string.Join(" ", line);
            lastLine = lastLine.PadRight(maxWidth);
            result.Add(lastLine);
        }

        return result;

    }
}





public partial class Solution
{
    public IList<string> FullJustify2(string[] words, int maxWidth)
    {
        //her string değerinin sonunda bir boşluk var
        List<string> result = new();
        StringInList(words, maxWidth, result);
        
        // foreach (var rslt in result)
        // {
        //     int length = rslt.Length - 1;
        //     for (int i = 0; i < maxWidth - length; i++)
        //     {
        //         for (int j = 0; j < length; j++)
        //         {
        //             char temp = rslt[j];
        //         }
        //         rslt.Replace(" ", "  ");
        //     }
        //     
        //     var deneme = rslt.Split(' ');
        //     
        // }
        int sum = 0;
        foreach (var rslt in result)
        {
            // rslt.
            // sum += rslt.Length;
        }
        
        

        return null;
        
    }
    
    private void StringInList(string[] words, int maxWidth, List<string> result)
    {
        string tempData = "";
        int sum = 0;

        foreach (var word in words)
        {
            if (sum + word.Length <= maxWidth)
            {
                sum += word.Length + 1;
                tempData += word;
                tempData += " ";
            }
            else
            {
                result.Add(tempData);
                tempData = "";
                sum = 0;
                sum += word.Length + 1;
                tempData += word;
                tempData += " ";
            }
        }

        if (tempData != "")
        {
            result.Add(tempData); 
        }
    }

    
}