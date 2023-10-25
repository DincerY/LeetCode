using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CustomHashTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashTable hashTable = new HashTable();
            hashTable.Insert(1,20);
            hashTable.Insert(11,30);
            hashTable.Insert(21,40);
            hashTable.Insert(12,50);
            hashTable.Insert(16,70);
            hashTable.Insert(15, 80);
            hashTable.Insert(25,90);
            hashTable.Insert(35,100);
            
            foreach (var hashTableItem in hashTable.Items)
            {
                Console.Write($"{hashTableItem.key}-{hashTableItem.data}/");
            }
        }
    }
    
    
}