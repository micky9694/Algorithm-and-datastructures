using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Queue<T>
    {
        //Declaring the necessary variables
        private T[] queue;
        private int size;
        public Queue()
        {
            size = 0;
            queue = new T[size];
        }

        //Adding a new element to the end of queue
        public void add(T element)
        {
            queue[size] = element;
            size += 1;
        }

        //Removing the first element of the queue
        public T remove()
        {
            T element = queue[0];
            if (size > 0)
            {
                for (int i = 1; i < size; i++)
                {
                    queue[i - 1] = queue[i];
                }
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
                Console.Write(queue[i]);
            }
        }
    }
}
