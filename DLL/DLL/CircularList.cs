using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class SingularCircularNode<T> where T : IComparable<T>
    {
        private T Data;
        private SingularCircularNode<T> Next;

        public SingularCircularNode()
        {
            Data = default(T);
            Next = null;
        }

        public SingularCircularNode(T Data)
        {
            this.Data = Data;
            Next = null;
        }

        public SingularCircularNode<T> GetNext()
        {
            return Next;
        }

        public void SetNext(SingularCircularNode<T> next)
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

    public class CircularList<T> where T : IComparable<T>
    {
        private SingularCircularNode<T> m_header;
        private SingularCircularNode<T> current;

        public CircularList()
        {
            m_header = new SingularCircularNode<T>();
            current = null;
            m_header.SetNext(m_header);
        }
        public CircularList(T item)
        {
            m_header = new SingularCircularNode<T>(item);
            current = null;
            m_header.SetNext(m_header);
        }

        public bool IsEmpty()
        {
            return (m_header.GetNext().Equals(null));
        }

        public void MakeEmpty()
        {
            m_header.SetNext(null);
        }

        private SingularCircularNode<T> Find(T Item)
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            current = m_header;
            while ((!current.GetData().Equals(Item)) && (!current.GetNext().Equals(null)))
            {
                current = current.GetNext();
            }
            if (!current.GetData().Equals(Item))
            {
                current = null;
            }
            return current;
        }

        private SingularCircularNode<T> FindLast()
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            current = m_header;
            do
            {
                current = current.GetNext();
            }
            while (!(current.GetNext().Equals(m_header)));

            return current;
        }

        private SingularCircularNode<T> FindPrevious(T Item)
        {
            SingularCircularNode<T> current = m_header;
            do
            {
                current = current.GetNext();
            }
            while (!(current.GetNext() == m_header) && (!current.GetNext().GetData().Equals(Item)));
            return current;
        }

        public void AddToEnd(T newItem)
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            SingularCircularNode<T> newNode = new SingularCircularNode<T>(newItem);

            while (!(current.GetNext() == m_header))
            {
                current = current.GetNext();
            }

            current.SetNext(newNode);
        }

        public void Insert(T newItem, T after)
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            SingularCircularNode<T> newNode = new SingularCircularNode<T>(newItem);

            current = Find(after);
            newNode.SetNext(current.GetNext());
            current.SetNext(newNode);
        }

        public void Remove(T Item)
        {
            SingularCircularNode<T> p = FindPrevious(Item);
            if (!(p.GetNext() == m_header))
            {
                p.SetNext(p.GetNext().GetNext());
            }
        }

        public void PrintList()
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            current = m_header;
            do
            {
                Console.WriteLine(current.GetNext().GetData());
                current.SetNext(current.GetNext());
            }
            while (!(current.GetNext().Equals(null)));
        }

    }
}