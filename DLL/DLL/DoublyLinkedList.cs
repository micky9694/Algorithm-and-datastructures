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
        private DoubleLinkNode<T> m_header;
        private DoubleLinkNode<T> current;
        private DoubleLinkNode<T> newNode;
        public DoublyLinkedList()
        {
            m_header = new DoubleLinkNode<T>();
            current = new DoubleLinkNode<T>();
            newNode = new DoubleLinkNode<T>();
        }
        public DoublyLinkedList(T item)
        {
            m_header = new DoubleLinkNode<T>(item);
            current = new DoubleLinkNode<T>();
            newNode = new DoubleLinkNode<T>();
        }

        private DoubleLinkNode<T> Find(T Item)
        {
            current = m_header;
            while ((!(current.getData().Equals(Item)) && (!(current.getNext() == null))))
            {
                current = current.getNext();
            }
            if (!current.getData().Equals(Item))
            {
                current = null;
            }
            return current;
        }

        private DoubleLinkNode<T> FindLast()
        { 
            current = m_header;
            while (!(current.getNext() == null))
            {
                current = current.getNext();
            }
            return current;         
        }

        public void AddToEnd(T newItem)
        {
            current = m_header;
            newNode = new DoubleLinkNode<T>(newItem);

            while (!(current.getNext() == null))
            {
                current = current.getNext();
            }
            
            current.setNext(newNode);
            newNode.setPrev(current);
        }

        public void Insert(T newItem, T after)
        {
            newNode = new DoubleLinkNode<T>(newItem);

            current = Find(after);
            newNode.setNext(current.getNext());
            newNode.setPrev(current);
            current.setNext(newNode);
        }

        public void Remove(T Item)
        {
            DoubleLinkNode<T> p = Find(Item);
            if (!(current.getNext() == null))
            {
                p.getPrev().setNext(p.getNext());
                p.getNext().setPrev(p.getPrev());
                p.setNext(null);
                p.setPrev(null);
            }
        }

        public void PrintList()
        {
            current = m_header;
            while (!(current.getNext() == null))
            {
                Console.WriteLine(current.getNext().getData().ToString());
                current = current.getNext();
            }
        }

        public void PrintReverse()
        {
            current = FindLast();
            while (!(current.getPrev() == null))
            {
                Console.WriteLine(current.getData().ToString());
                current = current.getPrev();
            }
        }
    }
}
