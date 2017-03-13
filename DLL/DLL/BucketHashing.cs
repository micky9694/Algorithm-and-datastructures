using DLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public struct Slot<T>: IComparable where T : IComparable {
        public T key;
        public T value;

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            if (obj.GetType().Equals(this.GetType()))
            {
                Slot<T> other = (Slot<T>)obj;
                return this.key.CompareTo(other.key);
            }
            else
                throw new ArgumentException("Object is not an Item");
        }
    }

    class HashTable<T> where T: IComparable
    {
        private GArrayList<Slot<T>> hashTable;
        private Slot<T> element;
        private int size;
        private BinarySearch bs = new BinarySearch();

        public HashTable()
        {
            hashTable = new GArrayList<Slot<T>>();
            size = 0;
        }

        public void Add(T key, T value)
        {
            element = new Slot<T>();
            element.key = key;
            element.value = value;

            if (bs.binarySearch(hashTable, element) != -1)
            {
                hashTable.Add(element);
                size++;
            }
            else
            {
                throw new Exception("The element already exists!");
            }
        }

        public void Clear()
        {
            if(size > 0)
            {
                for(int i = size - 1; i >= 0; i--)
                {
                    hashTable.Remove(i);
                }
                size = 0;
            }
        }

        public bool ContainsKey(Slot<T> element)
        {
           return bs.binarySearch(hashTable, element) != -1;
        }

        public void Remove(T key)
        {
            element = new Slot<T>();
            element.key = key;
            int found = bs.binarySearch(hashTable, element);
            if (found != -1)
            {
                hashTable.Remove(found);
            }
        }
    }

    class BucketHashing<T>
    {
        private GArrayList<T> bucket;
        private int size = 10;

        public BucketHashing()
        {
            bucket = new GArrayList<T>();
            for(int i = 0; i < size; i++)
            {
               // bucket.Add(new GArrayList<T>());
            }
        }

        public int Hash(T s)
        {
            return 0;
        }
  /*
        public void Insert(T item)
        {
            int hash_Value;
            hash_Value = Hash(item);
            if(bucket.Contains(item))
            {
                bucket.Insert(hash_Value, item);
            }
        }

        public void Remove(T item)
        {
            int hash_value;
            hash_value = Hash(item);
            if(bucket.Contains(item))
            {
                bucket.Remove(hash_value);
            }
        } */
    }
}
