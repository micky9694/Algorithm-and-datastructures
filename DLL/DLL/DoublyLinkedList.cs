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

        public DoubleLinkNode<T> GetNext()
        {
            return Next;
        }

        public void SetNext(DoubleLinkNode<T> next)
        {
            Next = next;
        }

        public DoubleLinkNode<T> GetPrev()
        {
            return Prev;
        }

        public void SetPrev(DoubleLinkNode<T> Prev)
        {
            this.Prev = Prev;
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

        private DoubleLinkNode<T> FindLast()
        { 
            current = m_header;
            while (!(current.GetNext() == null))
            {
                current = current.GetNext();
            }
            return current;         
        }

        public void AddToEnd(T newItem)
        {
            current = m_header;
            newNode = new DoubleLinkNode<T>(newItem);

            while (!(current.GetNext() == null))
            {
                current = current.GetNext();
            }
            
            current.SetNext(newNode);
            newNode.SetPrev(current);
        }

        public void Insert(T newItem, T after)
        {
            newNode = new DoubleLinkNode<T>(newItem);

            current = Find(after);
            newNode.SetNext(current.GetNext());
            newNode.SetPrev(current);
            current.SetNext(newNode);
        }

        public void Remove(T Item)
        {
            DoubleLinkNode<T> p = Find(Item);
            if (!(current.GetNext() == null))
            {
                p.GetPrev().SetNext(p.GetNext());
                p.GetNext().SetPrev(p.GetPrev());
                p.SetNext(null);
                p.SetPrev(null);
            }
        }

        public void PrintList()
        {
            current = m_header;
            while (!(current.GetNext() == null))
            {
                Console.WriteLine(current.GetNext().GetData().ToString());
                current = current.GetNext();
            }
        }

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
