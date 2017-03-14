﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Queue<T>
    {
        //Declaring the necessary variables
        private GArrayList<T> queue;
        private int size;
        public Queue()
        {
            queue = new GArrayList<T>();
            size = 0;
        }

        //Adding a new element to the end of queue
        public void add(T element)
        {
            queue.Add(element);
            size++;
        }

        //Removing the first element of the queue
        public T remove()
        {
            T element = queue.Get(0);
            if (size > 0)
            {
                queue.Remove(0);
                size -= 1;
            }
            return element;
        }

        //Finding out the size of the queue
        public int sizeQueue()
        {
            return size;
        }

        //Printing the queue
        public void printQueue()
        {
            Console.WriteLine("The queue is:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(queue.Get(i));
            }
        }
    }
}
