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

        public Node<T> getNext()
        {
            return Next;
        }

        public void setNext(Node<T> next)
        {
            Next = next;
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


    public class LinkedList<T> where T:IComparable<T>
    {
        private Node<T> m_header;
        public LinkedList()
        {
            m_header = new Node<T>();
        }
        public LinkedList(T item)
        {
            m_header = new Node<T>(item);
        }

        private Node<T> Find(T Item)
        {
            Node<T> current = new Node<T>();
            current = m_header;
            while((!current.getData().Equals(Item))&&(!current.getNext().Equals(null)))
            {
                current = current.getNext();
            }
            if(!current.getData().Equals(Item))
            {
                current = null;
            }
            return current;
        }

        private Node<T> FindPrevious(T Item)
        {
            Node<T> current = m_header;
            while(!(current.getNext().Equals(null))&&(!current.getNext().getData().Equals(Item)))
            {
                current = current.getNext();
            }
            return current;
        }

        public void Insert(T newItem, T after)
        {
            Node<T> current = new Node<T>();
            Node<T> newNode = new Node<T>(after);

            current = Find(after);
            newNode.setNext(current.getNext());
            current.setNext(newNode);
        }

        public void Remove(T Item)
        {
            Node <T> p = FindPrevious(Item);
            if(!(p.getNext().Equals(null)))
            {
                p.setNext(p.getNext().getNext());
            }
        }
    }
}
