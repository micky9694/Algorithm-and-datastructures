using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{   /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct Item<T>:IComparable<Item<T>>
    {
        public int priority;
        public T element;
        public T X
        {
            get 
            {
                return element;
            }

            set
            {
                element = value;
            }
        }

        public int CompareTo(Item<T> other)
        {
           if(this.priority < other.priority)
            {
                return -1;
            }
            else if(this.priority > other.priority)
            {
                return 1;
            } 
            return 0;
        }
    }

    class PriorityQueue<T> where T:IComparable
    {
        private  Item<T>[] priorityQueue;
        private int size;
        private Item<T> i;
        public PriorityQueue()
        {
            size = 0;
            priorityQueue = new Item<T>[size];
        }

        public void add(int priority, T element)
        {
            //Add sort method from Chen's files!
            i = new Item<T>();
            i.priority = priority;
            i.element = element;
            priorityQueue[size] = i;
            size += 1;
        }

        public Item<T> remove()
        {
            Item<T> item = priorityQueue[0];
            if (size > 0)
            {
                for (int i = 1; i < size; i++)
                {
                    priorityQueue[i - 1] = priorityQueue[i];
                }
                size -= 1;
            }  
            return item;
        }

        public int sizePriorityQueue()
        {
            return size;
        }
    }
}
