LRUCache lruCache = new(2);
//LRUCache2 lruCache = new(10);
// lruCache.Put(1, 1);
// lruCache.Put(2, 2);
// lruCache.Get(1);
// lruCache.Put(3, 3);  
// lruCache.Get(2);
// lruCache.Put(4, 4);
// lruCache.Get(1);
// lruCache.Get(3);
// lruCache.Get(4);

lruCache.Get(2);
lruCache.Put(2, 6);
lruCache.Get(1);
lruCache.Put(1, 5);
lruCache.Put(1, 2);
lruCache.Get(1);
lruCache.Get(2);


Console.WriteLine("Hello, World!");


public class LRUCache
{
    private readonly Dictionary<int, int> _dic;
    private readonly List<int> _list;
    private readonly int _capacity;

    public LRUCache(int capacity)
    {
        _capacity = capacity;
        _list = new List<int>();
        _dic = new Dictionary<int, int>(capacity);
    }

    public int Get(int key)
    {
        if (_dic.ContainsKey(key))
        {
            int val;
            _dic.TryGetValue(key, out val);
            int keyIndex = Array.IndexOf(_list.ToArray(), key);
            _list.RemoveAt(keyIndex);
            _list.Add(key);
            return val;
        }
        else
        {
            return -1;
        }
    }

    public void Put(int key, int value)
    {
        if (_dic.ContainsKey(key))
        {
            _dic.Remove(key);
            _dic.Add(key,value);
            int delKey = Array.IndexOf(_list.ToArray(), key);
            _list.RemoveAt(delKey);
            _list.Add(key);
        }
        else
        {
            if (_dic.Count >= _capacity)
            {
                int deletedKey = _list[0];
                _list.RemoveAt(0);
                _dic.Remove(deletedKey);
            }
            _dic.Add(key, value);
            _list.Add(key);
        }
    }
}

//it is not mine solution
public class LRUCache2
{
    private readonly int capacity;
    private readonly Dictionary<int, LinkedListNode<CacheItem>> cacheMap;
    private readonly LinkedList<CacheItem> cacheList;

    public LRUCache2(int capacity)
    {
        this.capacity = capacity;
        cacheMap = new Dictionary<int, LinkedListNode<CacheItem>>(capacity);
        cacheList = new LinkedList<CacheItem>();
    }

    public int Get(int key)
    {
        if (cacheMap.TryGetValue(key, out var node))
        {
            cacheList.Remove(node);
            cacheList.AddFirst(node);
            return node.Value.Value;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (cacheMap.TryGetValue(key, out var node))
        {
            node.Value.Value = value;
            cacheList.Remove(node);
            cacheList.AddFirst(node);
        }
        else
        {
            if (cacheMap.Count >= capacity)
            {
                var lastNode = cacheList.Last;
                cacheMap.Remove(lastNode.Value.Key);
                cacheList.RemoveLast();
            }

            var newNode = new LinkedListNode<CacheItem>(new CacheItem(key, value));
            cacheMap.Add(key, newNode);
            cacheList.AddFirst(newNode);
        }
    }

    private class CacheItem
    {
        public int Key { get; }
        public int Value { get; set; }

        public CacheItem(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}