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
        private T[] stack;
        private int size;
        public Stack()
        {
            size = 0;
            stack = new T[size];
        }

        //Adding a new element on the top of the stack
        public void push(T element)
        {
            stack[size] = element;
            size += 1;
        }

        //Removing the top element of the stack
        public T pop()
        {
            T element = stack[size];
            if (size > 0)
            {
                size -= 1;
            }
            else
            {
                size = 0;
            }
            return element;
        }

        //Finding out the size of the stack
        public int sizeStack()
        {
            return size;
        }

        //Printing the stack
        public void printStack()
        {
            Console.WriteLine("The stack is:");
            for (int i = size-1; i >= 0; i--)
            {
                Console.Write(stack[i]);
            }
        }
    }
}
