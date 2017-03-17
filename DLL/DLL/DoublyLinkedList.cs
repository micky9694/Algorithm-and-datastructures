using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class DoubleLinkNode<T> where T : IComparable<T>
    {
        private T Data;
        private DoubleLinkNode<T> Next;
        private DoubleLinkNode<T> Prev;

        public DoubleLinkNode()
        {
            Data = default(T);
            Next = null;
            Prev = null;
        }

        public DoubleLinkNode(T Data)
        {
            this.Data = Data;
            Next = null;
            Prev = null;
        }

        public DoubleLinkNode<T> getNext()
        {
            return Next;
        }

        public void setNext(DoubleLinkNode<T> next)
        {
            Next = next;
        }

        public DoubleLinkNode<T> getPrev()
        {
            return Prev;
        }

        public void setPrev(DoubleLinkNode<T> Prev)
        {
            this.Prev = Prev;
        }

        public void addData(T Data)
        {
            this.Data = Data;
        }

        public T getData()
        {
            return Data;
        }
    }

    public class DoublyLinkedList<T> where T : IComparable<T>
    {
        //Variables used during the rest of the doubly linked list
        private DoubleNode<T> m_header;
        private DoubleNode<T> current;
        private DoubleNode<T> newNode;

        //Constructers
        public DoublyLinkedList()
        {
            m_header = new DoubleNode<T>();
            current = new DoubleNode<T>();
            newNode = new DoubleNode<T>();
        }
        public DoublyLinkedList(T item)
        {
            m_header = new DoubleNode<T>(item);
            current = new DoubleNode<T>();
            newNode = new DoubleNode<T>();
        }

        /// <summary>
        /// This private method is used to run a search through the linked list to find an object specified in Item
        /// </summary>
        /// <param name="Item">Generic object that is searched for in the Linked list</param>
        /// <returns>Generic node used in other methods</returns>
        private DoubleNode<T> Find(T Item)
        {
            current = m_header;
            while ((!(current.GetData().Equals(Item)) && (!(current.GetNext() == null))))
            {
                current = current.GetNext();
            }
            if (!current.GetData().Equals(Item))
            {
                current = null;
            }
            return current;
        }

        /// <summary>
        /// This method is used to find the last value in the doubly linked list
        /// </summary>
        /// <returns>the found node</returns>
        private DoubleNode<T> FindLast()
        { 
            current = m_header;
            while (!(current.GetNext() == null))
            {
                current = current.GetNext();
            }
            return current;         
        }

        public void addToEnd(T newItem)
        {
            current = m_header;
            newNode = new DoubleNode<T>(newItem);

            while (!(current.GetNext() == null))
            {
                current = current.GetNext();
            }
            
            current.SetNext(newNode);
            newNode.SetPrev(current);
        }

        /// <summary>
        /// Insert used to add an Item anywhere into the list after any given value
        /// </summary>
        /// <param name="newItem">New Item being added into the linked list</param>
        /// <param name="after">After this value the new Item will be added</param>
        public void Insert(T newItem, T after)
        {
            newNode = new DoubleNode<T>(newItem);

            current = Find(after);
            newNode.SetNext(current.GetNext());
            newNode.SetPrev(current);
            current.SetNext(newNode);
        }

        /// <summary>
        /// This method will remove the given Item from the list and ajust all links
        /// </summary>
        /// <param name="Item">Item to be removed</param>
        public void Remove(T Item)
        {
            DoubleLinkNode<T> p = Find(Item);
            if (!(current.getNext() == null))
            {
                p.GetPrev().SetNext(p.GetNext());
                p.GetNext().SetPrev(p.GetPrev());
                p.SetNext(null);
                p.SetPrev(null);
            }
        }

        /// <summary>
        /// Print all data values in the linked list
        /// </summary>
        public void PrintList()
        {
            current = m_header;
            while (!(current.GetNext() == null))
            {
                Console.WriteLine(current.GetNext().GetData().ToString());
                current = current.GetNext();
            }
        }

        /// <summary>
        /// This is the same as above but instead prints the list in reverse
        /// </summary>
        public void PrintReverse()
        {
            current = FindLast();
            while (!(current.GetPrev() == null))
            {
                Console.WriteLine(current.GetData().ToString());
                current = current.GetPrev();
            }
        }
    }
}
