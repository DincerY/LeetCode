MinStack minStack = new();
minStack.Push(-2);
minStack.Push(0);
minStack.Push(-3);
minStack.GetMin(); 
minStack.Pop();
minStack.Top();    
minStack.GetMin(); 


Console.WriteLine("Hello, World!");


public class MinStack
{
    private List<int> _list;

    private int _tailIndex;
    public MinStack()
    {
        _list = new List<int>();
        _tailIndex = 0;
    }

    public void Push(int val)
    {
        _list.Add(val);
        _tailIndex++;
    }

    public void Pop()
    {
        if (_tailIndex == 0)
        {
            return;
        }
        _list.RemoveAt(_tailIndex-1);
        _tailIndex--;
    }

    public int Top()
    {
        return _list[_tailIndex-1];
    }

    public int GetMin()
    {
        return _list.Min();
    }
}