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

        public SingularCircularNode<T> getNext()
        {
            return Next;
        }

        public void setNext(SingularCircularNode<T> next)
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

    public class CircularList<T> where T : IComparable<T>
    {
        private SingularCircularNode<T> m_header;
        private SingularCircularNode<T> current;

        public CircularList()
        {
            m_header = new SingularCircularNode<T>();
            current = null;
            m_header.setNext(m_header);
        }
        public CircularList(T item)
        {
            m_header = new SingularCircularNode<T>(item);
            current = null;
            m_header.setNext(m_header);
        }

        public bool IsEmpty()
        {
            return (m_header.getNext().Equals(null));
        }

        public void MakeEmpty()
        {
            m_header.setNext(null);
        }

        private SingularCircularNode<T> Find(T Item)
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            current = m_header;
            while ((!current.getData().Equals(Item)) && (!current.getNext().Equals(null)))
            {
                current = current.getNext();
            }
            if (!current.getData().Equals(Item))
            {
                current = null;
            }
            return current;
        }

        private SingularCircularNode<T> FindLast()
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            current = m_header;
            while (!(current.getNext().Equals(m_header)))
            {
                current = current.getNext();
            }
            return current;
        }

        private SingularCircularNode<T> FindPrevious(T Item)
        {
            SingularCircularNode<T> current = m_header;
            while (!(current.getNext().Equals(null)) && (!current.getNext().getData().Equals(Item)))
            {
                current = current.getNext();
            }
            return current;
        }

        public void addToEnd(T newItem)
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            SingularCircularNode<T> newNode = new SingularCircularNode<T>(newItem);

            while (!current.getNext().Equals(null))
            {
                current = current.getNext();
            }

            current.setNext(newNode);
            newNode.setPrev(current);

        }

        public void Insert(T newItem, T after)
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            SingularCircularNode<T> newNode = new SingularCircularNode<T>(newItem);

            current = Find(after);
            newNode.setNext(current.getNext());
            newNode.setPrev(current);
            current.setNext(newNode);
        }

        public void Remove(T Item)
        {
            SingularCircularNode<T> p = Find(Item);
            if (!(p.getNext().Equals(null)))
            {
                p.getPrev().setNext(p.getNext());
                p.getNext().setPrev(p.getPrev());
                p.setNext(null);
                p.setPrev(null);
            }
        }

        public void PrintList()
        {
            SingularCircularNode<T> current = new SingularCircularNode<T>();
            current = m_header;
            while (!(current.getNext().Equals(null)))
            {
                Console.WriteLine(current.getNext().getData());
                current.setNext(current.getNext());
            }
        }

    }
}
