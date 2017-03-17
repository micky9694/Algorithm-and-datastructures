using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace LinearHashTable
{
    public class LinearHashTable<T> : IEnumerable
    {
        private T[] list;
        private int percentageBorder;

        public LinearHashTable()
        {
            list = new T[10];
            percentageBorder = 75;
        }

        public bool Add(T key)
        {
            try
            {
                int index = HashFunction(key);

                // If there is a collision, go to the next index
                // If the list has ended, go to the beginning of the list
                while (list[index] != null)
                {
                    if (index >= (list.Length) - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                }
                list[index] = key;

                // If the list is more than the percentage border full, make 10 new slots
                if (GetOccupiedPercentage() > percentageBorder)
                {
                    RefreshTable(10);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Contains(T key)
        {
            try
            {
                int index = HashFunction(key);

                // Keep searching until you find the right key or an empty spot
                while (list[index] != null && !EqualityComparer<T>.Default.Equals(list[index], key))
                {
                    index++;
                }

                if (list[index] == null)
                {
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(T key)
        {
            try
            {
                int index = HashFunction(key);

                // Check if this is the same key
                while (list[index] != null && !EqualityComparer<T>.Default.Equals(list[index], key))
                {
                    index++;
                }

                list[index] = default(T);
                RefreshTable(0);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int HashFunction(T key)
        {
            if (key == null)
            {
                return -1;
            }

            int hash = 0;

            // Check if it is a collection
            if (typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(typeof(T).GetTypeInfo()))
            {
                hash = GetHashForCollection((IEnumerable)key);
            }
            else
            {
                hash = key.GetHashCode();
            }

            // Return the right hash code
            return (hash % list.GetUpperBound(0));
        }

        private int GetHashForCollection(IEnumerable collection)
        {
            int total = 0;
            int count = 0;
            foreach (object item in collection)
            {
                total += item.GetHashCode();
                count++;
            }

            return (total / count);
        }

        /// <summary>
        /// Gets the percentage of how much the list is occupied
        /// </summary>
        /// <returns></returns>
        public decimal GetOccupiedPercentage()
        {
            decimal amountOccupied = 0;

            // Count the amount of occupied spaces
            foreach (T item in list)
            {
                if (item != null)
                {
                    amountOccupied++;
                }
            }

            return (amountOccupied / list.Length) * 100;
        }

        /// <summary>
        /// Refresh the table and increase the amount of slots if possible
        /// </summary>
        private void RefreshTable(int increment)
        {
            // First overwrite the current list with the new list
            // And save the old list where the data is in
            T[] newList = new T[list.Length + increment];
            T[] oldList = list;
            list = newList;

            // Copy all the data to the new list
            // Make use of the hash function for this
            for (int i = 0; i < oldList.Length; i++)
            {
                if (oldList[i] != null)
                {
                    Add(oldList[i]);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<T>(list);
        }
    }

    class Enumerator<T> : IEnumerator
    {
        public T[] list;
        int position = -1;

        public Enumerator(T[] items)
        {
            list = items;
        }

        public bool MoveNext()
        {
            position++;
            return (position < list.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                try
                {
                    return list[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

