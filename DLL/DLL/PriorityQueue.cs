using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL { 
    public struct Item<T>:IComparable where T: IComparable
    {
        public int priority;
        public T element;
        public T Element
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

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (obj.GetType().Equals(this.GetType()))
            {
                Item<T> other = (Item<T>) obj;
                return this.priority.CompareTo(other.priority);
            }
            else
                throw new ArgumentException("Object is not an Item");
        }
    }

    class PriorityQueue<T> where T:IComparable
    {
        private static int size = 0;
        private GArrayList<Item<T>> priorityQueue;
        private Item<T> i;
        private SmartBubbleSort bubbleSort = new SmartBubbleSort();
        public PriorityQueue()
        {
            size = 0;
            priorityQueue = new GArrayList<Item<T>>();
        }

        public void Add(int priority, T element)
        {
            i = new Item<T>();
            i.priority = priority;
            i.element = element;
            priorityQueue.Add(i);
            bubbleSort.BubbleSorting(priorityQueue);
            size += 1;
        }

        public Item<T> Remove()
        {
            Item<T> item = priorityQueue.Get(0);
            if (size > 0)
            {
                priorityQueue.Remove(0);
                size -= 1;
            }  
            return item;
        }

        public int SizePriorityQueue()
        {
            return size;
        }

        public void PrintPriorityQueue()
        {
        Console.WriteLine("The priority queue is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(priorityQueue.Get(i));
            }
        }
    }
}
