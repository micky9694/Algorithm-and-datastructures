﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DoublyLinkedList<T> where T : IComparable<T>
    {
        private DoubleNode<T> m_header;
        private DoubleNode<T> current;
        private DoubleNode<T> newNode;
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

        private DoubleNode<T> FindLast()
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
            newNode = new DoubleNode<T>(newItem);

            while (!(current.GetNext() == null))
            {
                current = current.GetNext();
            }
            
            current.SetNext(newNode);
            newNode.SetPrev(current);
        }

        public void Insert(T newItem, T after)
        {
            newNode = new DoubleNode<T>(newItem);

            current = Find(after);
            newNode.SetNext(current.GetNext());
            newNode.SetPrev(current);
            current.SetNext(newNode);
        }

        public void Remove(T Item)
        {
            DoubleNode<T> p = Find(Item);
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
