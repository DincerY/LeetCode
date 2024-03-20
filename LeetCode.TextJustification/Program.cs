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


public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        //her string değerinin sonunda bir boşluk var
        List<string> result = new();
        StringInList(words, maxWidth, result);

        foreach (var rslt in result)
        {
            int length = rslt.Length - 1;
            var deneme = rslt.Split(' ');
            
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