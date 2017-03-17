using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Stack<T>
    {
        //Declaring the necessary variables
        private GArrayList<T> stack;
        private int size;
        public Stack()
        {
            stack = new GArrayList<T>();
            size = 0;
        }

        //Adding a new element on the top of the stack
        public void Push(T element)
        {
            stack.Add(element);
            size += 1;
        }

        //Removing the top element of the stack
        public T Pop()
        {
            T element = stack.Get(size-1);
            if (size > 0)
            {
                stack.Remove(size - 1);
                size -= 1;
            }
            else
            {
                size = 0;
            }
            return element;
        }

        //Finding out the size of the stack
        public int SizeStack()
        {
            return size;
        }

        //Printing the stack
        public void PrintStack()
        {
            Console.WriteLine("The stack is:");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(stack.Get(i));
            }
        }

        public void Clear()
        {
            for (int i=size-1; i>=0; i--)
            {
                stack.Remove(i);
            }
        }

        public T Peek()
        {
            return stack.Get(size-1);
        }
    }
}
