using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DoubleCircularList<T> where T : IComparable<T>
    {
        private DoubleNode<T> m_header;
        private DoubleNode<T> current;
        private DoubleNode<T> newNode;

        public DoubleCircularList()
        {
            m_header = new DoubleNode<T>();
            current = new DoubleNode<T>();
            newNode = new DoubleNode<T>();
            m_header.SetNext(m_header);
            m_header.SetPrev(m_header);
        }
        public DoubleCircularList(T item)
        {
            m_header = new DoubleNode<T>(item);
            current = new DoubleNode<T>();
            newNode = new DoubleNode<T>();
            m_header.SetNext(m_header);
            m_header.SetPrev(m_header);
        }

        public bool IsEmpty()
        {
            return ((m_header.GetNext() == null)&&(m_header.GetPrev() ==null));
        }

        public void MakeEmpty()
        {
            m_header.SetNext(m_header);
            m_header.SetPrev(m_header);
        }

        private DoubleNode<T> Find(T Item)
        {
            current = m_header;
            while ((!current.GetData().Equals(Item)) && (!(current.GetNext() == m_header)))
            {
                current = current.GetNext();
            }
            if (!current.GetData().Equals(Item))
            {
                current = null;
            }
            return current;
        }

        private DoubleNode<T> FindLast()
        {
            current = m_header;
            do
            {
                current = current.GetNext();
            }
            while (!(current.GetNext().Equals(m_header)));

            return current;
        }

        private DoubleNode<T> FindPrevious(T Item)
        {
            current = m_header;
            do
            {
                current = current.GetNext();
            }
            while (!(current.GetNext() == m_header) && (!current.GetNext().GetData().Equals(Item)));
            return current;
        }

        public void AddToEnd(T newItem)
        {
            current = m_header;
            newNode = new DoubleNode<T>(newItem);

            while (!(current.GetNext() == m_header))
            {
                current = current.GetNext();
            }

            current.SetNext(newNode);
            newNode.SetPrev(current);
            newNode.SetNext(m_header);
        }

        public void Insert(T newItem, T after)
        {
            DoubleNode<T> current = new DoubleNode<T>();
            DoubleNode<T> newNode = new DoubleNode<T>(newItem);

            current = Find(after);
            newNode.SetNext(current.GetNext());
            newNode.SetPrev(current);
            current.SetNext(newNode);
        }

        public void Remove(T Item)
        {
            DoubleNode<T> p = FindPrevious(Item);
            if (!(p.GetNext() == m_header))
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
            do
            {
                Console.WriteLine(current.GetData());
                current = current.GetNext();
            }
            while (!(current == m_header));
        }
    }
}
