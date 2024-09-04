LRUCache lruCache = new(2);
lruCache.Get(2);
lruCache.Put(3,3);
lruCache.Put(4,4);
lruCache.Put(5,5);


Console.WriteLine("Hello, World!");


public class LRUCache
{
    private Dictionary<int, int> _dic;
    private Queue<int> _queue;
    private int _capacity;
    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _queue = new Queue<int>();
        _dic = new Dictionary<int, int>(capacity);
    }

    public int Get(int key)
    {
        if (_dic.ContainsKey(key))
        {
            int val;
            _dic.TryGetValue(key,out val);
            return val;
        }
        else
        {
            return -1;
        }
        
    }

    public void Put(int key, int value)
    {
        if (_dic.Count >= _capacity)
        {
            int deletedKey = _queue.Dequeue();
            _dic.Remove(deletedKey);
            _dic.Add(key,value);
        }
        else
        {
            _dic.Add(key,value);
            _queue.Enqueue(key);
        }
    }
}