using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Node<T> where T : IComparable<T>
    {
        private T Data;
        private Node<T> Next;

        public Node()
        {
            Data = default(T);
            Next = null;
        }

        public Node(T Data)
        {
            this.Data = Data;
            Next = null;
        }

        public Node<T> GetNext()
        {
            return Next;
        }

        public void SetNext(Node<T> next)
        {
            Next = next;
        }

        public void AddData(T Data)
        {
            this.Data = Data;
        }

        public T GetData()
        {
            return Data;
        }
    }


    public class LinkedList<T> where T:IComparable<T>
    {
        private Node<T> m_header;
        private Node<T> current;
        public LinkedList()
        {
            m_header = new Node<T>();
            current = new Node<T>();
        }
        public LinkedList(T item)
        {
            m_header = new Node<T>(item);
            current = new Node<T>();
        }

        private Node<T> Find(T Item)
        {
            current = m_header;
            while((!current.GetData().Equals(Item))&&(!(current.GetNext() ==null)))
            {
                current = current.GetNext();
            }
            if(!current.GetData().Equals(Item))
            {
                current = null;
            }
            return current;
        }

        private Node<T> FindPrevious(T Item)
        {
            Node<T> current = m_header;
            while((!(current.GetNext() == null))&&(!current.GetNext().GetData().Equals(Item)))
            {
                current = current.GetNext();
            }
            return current;
        }

        public void AddToEnd(T newItem)
        {
            Node<T> current = new Node<T>();
            current = m_header;
            Node<T> newNode = new Node<T>(newItem);
            
            while(!(current.GetNext() == null))
            {
                current = current.GetNext();
            }

            current.SetNext(newNode);
        }

        public void Insert(T newItem, T after)
        {
            Node<T> current = new Node<T>();
            Node<T> newNode = new Node<T>(newItem);

            current = Find(after);
            newNode.SetNext(current.GetNext());
            current.SetNext(newNode);
        }

        public void Remove(T Item)
        {
            Node <T> p = FindPrevious(Item);
            if(!(p.GetNext() == null))
            {
                p.SetNext(p.GetNext().GetNext());
            }
        }

        public void PrintList()
        {
            Node<T> current = new Node<T>();
            current = m_header;
            while(!(current.GetNext() == null))
            {
                Console.WriteLine(current.GetNext().GetData());
                current =current.GetNext();
            }
        }
    }
}
