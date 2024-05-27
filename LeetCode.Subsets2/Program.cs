Solution solution = new();
// solution.SubsetsWithDup(new[]
// {
//     1, 2, 2
// });

solution.Subsets();



Console.WriteLine("Hello, World!");



public partial class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        return null;
    }
    
    public List<List<int>> Subsets(int[] nums)
    {
        //başlangıç indexi yazıcaz daha sonra bu index sonuna kadar gidicek sonrasında bir artacak ve arttığında 
        //öncesi alınmayacak
        List<IList<int>> result = new List<IList<int>>();
        List<int> list = new List<int>();
        Recursion();
        
        void Recursion()
        {
           
            Recursion();
            Recursion();    
        }

        return null;
    }
}