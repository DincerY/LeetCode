namespace CustomHashTable
{
    public class HashTable
    {
        private const int Size = 10; 
        public class DataItem
        {
            public int key;
            public int data;
        }
        public DataItem[] Items { get; set; }

        public HashTable(int size = Size)
        {
            Items = new DataItem[]
            {
                new DataItem(),
                new DataItem(),
                new DataItem(),
                new DataItem(),
                new DataItem(),
                new DataItem(),
                new DataItem(),
                new DataItem(),
                new DataItem(),
                new DataItem(),
            };
            for (int i = 0; i < size; i++)
            {
                Items[i].data = 0;
                Items[i].key = 0;
                
            }
        }

        public void Insert(int key, int data)
        {
            int hashKey = HashAlgorithm(key);
            if (Items[hashKey].key == 0)
            {
                Items[hashKey].key = key;
                Items[hashKey].data = data;
            }
            else if(Items[hashKey].key == key)
            {
                Items[hashKey].data = data;
            }
            else
            {
                LinearProbing(key, data);
            }
        }

        private void LinearProbing(int key,int data,int size = Size)
        {
            int hashKey = HashAlgorithm(key + 1);
            for (int i = hashKey; i < size; i++)
            {
                if (Items[i].key == 0)
                {
                    Items[i].key = key;
                    Items[i].data = data;
                    return;
                }
            }
        }
        
        /// <summary>
        /// Hashing and return index
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int HashAlgorithm(int key)
        {
            return key % Size;
        }
    }
}