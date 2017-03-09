using System;
using System.Collections;

namespace DLL
{
    public class GArrayList<T> : IEnumerable
    {
        private T[] list;

        public GArrayList()
        {
            list = new T[0];
        }

        public T Get(int position)
        {
            try
            {
                return list[position];
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public object Add(T item)
        {
            try
            {
                CopyListPlusOne();

                // Save the new item
                list[list.Length - 1] = item;

                return true;
            }
            catch(Exception e)
            {
                return e;
            }
        }

        public object Insert(int position, T value)
        {
            try
            {
                CopyListPlusOne();
                MoveListUp(position);
                list[position] = value;
                return true;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public object Remove(int position)
        {
            try
            {
                CopyListMinusOne(position);
                return true;
            }
            catch (Exception e)
            {
                return e;
            }
        } 

        private void CopyListPlusOne()
        {
            // First create an empty list + 1 slot
            T[] newList = new T[list.Length + 1];

            // Copy all the entries from the current list to the new list
            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            // Make the new list as the current list
            list = newList;
        }

        private void CopyListMinusOne(int position)
        {
            // First create an empty list - 1 slot
            T[] newList = new T[list.Length - 1];

            // Copy all the entries from the current list to the new list
            // Skip the specified position
            for (int i=0; i<=newList.Length; i++)
            {
                if (i < position)
                {
                    newList[i] = list[i];
                }
                else if(i > position)
                {
                    newList[i - 1] = list[i];
                }
            }

            // Make the new list as the current list
            list = newList;
        }

        private void MoveListUp(int position)
        {
            for (int i=list.Length-2; i>=position; i--)
            {
                // Move the current entry one up
                list[i + 1] = list[i];
            }
        }

        private void MoveListDown(int position)
        {

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator<T>(list);
        }

        private int Size()
        {
            int count = 0;
            for (int i=0; i<list.Length; i++)
            {
                if (list[i] != null)
                {
                    count++;
                }
            }
            return count;
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
