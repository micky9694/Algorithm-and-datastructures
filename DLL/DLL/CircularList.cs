using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class CircularNode<T> where T : IComparable<T>
    {
        private T Data;
        private CircularNode<T> Next;
        private CircularNode<T> Prev;

        public CircularNode()
        {
            Data = default(T);
            Next = null;
            Prev = null;
        }

        public CircularNode(T Data)
        {
            this.Data = Data;
            Next = null;
            Prev = null;
        }

        public CircularNode<T> getNext()
        {
            return Next;
        }

        public void setNext(CircularNode<T> next)
        {
            Next = next;
        }

        public CircularNode<T> getPrev()
        {
            return Prev;
        }

        public void setPrev(CircularNode<T> Prev)
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

    public class CircularList<T> where T : IComparable<T>
    {
        private CircularNode<T> m_header;
        private CircularNode<T> current;

        public CircularList()
        {
            m_header = new CircularNode<T>();
            current = null;
            m_header.setPrev(m_header);
        }
        public CircularList(T item)
        {
            m_header = new CircularNode<T>(item);
            current = null;
        }

        public bool IsEmpty()
        {
            return (m_header.getNext().Equals(null));
        }

        public void MakeEmpty()
        {
            m_header.setPrev(null);
            m_header.setNext(null);
        }

        private CircularNode<T> Find(T Item)
        {
            CircularNode<T> current = new CircularNode<T>();
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

        private CircularNode<T> FindLast()
        {
            CircularNode<T> current = new CircularNode<T>();
            current = m_header;
            while (!(current.getNext().Equals(null)))
            {
                current = current.getNext();
            }
            return current;
        }

        private CircularNode<T> FindPrevious(T Item)
        {
            CircularNode<T> current = m_header;
            while (!(current.getNext().Equals(null)) && (!current.getNext().getData().Equals(Item)))
            {
                current = current.getNext();
            }
            return current;
        }

        public void addToEnd(T newItem)
        {
            CircularNode<T> current = new CircularNode<T>();
            CircularNode<T> newNode = new CircularNode<T>(newItem);

            while (!current.getNext().Equals(null))
            {
                current = current.getNext();
            }

            current.setNext(newNode);
            newNode.setPrev(current);

        }

        public void Insert(T newItem, T after)
        {
            CircularNode<T> current = new CircularNode<T>();
            CircularNode<T> newNode = new CircularNode<T>(newItem);

            current = Find(after);
            newNode.setNext(current.getNext());
            newNode.setPrev(current);
            current.setNext(newNode);
        }

        public void Remove(T Item)
        {
            CircularNode<T> p = Find(Item);
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
            CircularNode<T> current = new CircularNode<T>();
            current = m_header;
            while (!(current.getNext().Equals(null)))
            {
                Console.WriteLine(current.getNext().getData());
                current.setNext(current.getNext());
            }
        }

        public void PrintReverse()
        {
            CircularNode<T> current = new CircularNode<T>();
            current = FindLast();
            while (!(current.getPrev().Equals(null)))
            {
                Console.WriteLine(current.getData());
                current = current.getPrev();
            }
        }
    }
}
