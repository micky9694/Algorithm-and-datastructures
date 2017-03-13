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
            hashTable.Add(element);
            size++;
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

        public void ContainsKey()
        {

        }
    }
    class BucketHashing <T>
    {
        private const int size = 101;
        //add arrayList 
        ArrayList[] data;

        public BucketHashing()
        {
            data = new ArrayList[size];
            for (int i = 0; i<=size-1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

        public int Hash(String a)
        {
            long tot = 0;
            char[] charray;
            charray = a.ToCharArray();
            int length = a.Length;
            for (int i = 0; i<= length-1;i++)
            {
                tot += 37 * tot + (int)charray[i];
            }
            tot = tot % data.GetUpperBound(0);
            if(tot<0)
            {
                tot += data.GetUpperBound(0);
            }
            return (int)tot;
        }

        public void Insert (String item)
        {
            /*bool found = false;
            int i = 0;
            while ((i<size) && (found == false))
            {
                if(data[i].Equals(item))
                {
                    found = true;
                }
                i++;
            }
            if (found == true)
            {
                data[size] = item;
            }
            else
            {
                Console.Write("The item is already in the bucket.");
            } */
            int hash_value;
            hash_value = Hash(value);
            
        }

        public void Remove (String item)
        {
            bool found = false;
            int place = 0;
            int i = 0;
            while ((i<size)&&(found==false))
                {
                if (data[i].Equals(item))
                {
                    found = true;
                    place = i;
                }
                i++;
            }
            if (found == true)
            {
                for (i = place; i<size; i++)
                {
                    data[place] = data[place + 1];
                }
                size -= 1;
            }
        }
    }
}
