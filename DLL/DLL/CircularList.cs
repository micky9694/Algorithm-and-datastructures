﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class CircularList<T> where T : IComparable<T>
    {
        //Variables used in this circular list
        private SingularLinkNode<T> m_header;
        private SingularLinkNode<T> current;
        private SingularLinkNode<T> newNode;

        //Constructers
        public CircularList()
        {
            m_header = new SingularLinkNode<T>();
            current = null;
            m_header.SetNext(m_header);
        }
        public CircularList(T item)
        {
            m_header = new SingularLinkNode<T>(item);
            current = null;
            m_header.SetNext(m_header);
        }

        /// <summary>
        /// This method is used to check if the circularlist is empty of not
        /// </summary>
        /// <returns>Boolean value of true or false</returns>
        public bool IsEmpty()
        {
            return (m_header.GetNext().Equals(null));
        }

        /// <summary>
        /// This method will make the circular listt completly emply
        /// </summary>
        public void MakeEmpty()
        {
            m_header.SetNext(null);
        }

        /// <summary>
        /// This private method is used to run a search through the linked list to find an object specified in Item
        /// </summary>
        /// <param name="Item">Generic object that is searched for in the Linked list</param>
        /// <returns>Generic node used in other methods</returns>
        private SingularLinkNode<T> Find(T Item)
        {
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

        /// <summary>
        /// This method is used to find the last value in the doubly linked list
        /// </summary>
        /// <returns>the found node</returns>
        private SingularLinkNode<T> FindLast()
        {
            current = m_header;
            while (!(current.GetNext().Equals(m_header)))
            {
                current = current.GetNext();
            }
            while (!(current.GetNext() == m_header));

            return current;
        }

        /// <summary>
        /// Same concept as above Find except that it finds the previous node to the one in Item
        /// </summary>
        /// <param name="Item">Genreic field used in the search</param>
        /// <returns>return node</returns>
        private SingularLinkNode<T> FindPrevious(T Item)
        {
            SingularLinkNode<T> current = m_header;
            while (!(current.GetNext().Equals(null)) && (!current.GetNext().GetData().Equals(Item)))
            {
                current = current.GetNext();
            }
            while (!(current.GetNext() == m_header) && (!current.GetNext().GetData().Equals(Item)));
            return current;
        }

        public void addToEnd(T newItem)
        {
            current = m_header;
            newNode = new SingularLinkNode<T>(newItem);

            while (!current.GetNext().Equals(null))
            {
                current = current.GetNext();
            }

            current.SetNext(newNode);
           // newNode.setPrev(current);

        }

        /// <summary>
        /// Insert used to add an Item anywhere into the list after any given value
        /// </summary>
        /// <param name="newItem">New Item being added into the linked list</param>
        /// <param name="after">After this value the new Item will be added</param>
        public void Insert(T newItem, T after)
        {
            newNode = new SingularLinkNode<T>(newItem);

            current = Find(after);
            newNode.SetNext(current.GetNext());
          //  newNode.setPrev(current);
            current.SetNext(newNode);
        }

        /// <summary>
        /// This method will remove the given Item from the list and ajust all links
        /// </summary>
        /// <param name="Item">Item to be removed</param>
        public void Remove(T Item)
        {
            SingularLinkNode<T> p = Find(Item);
            if (!(p.GetNext().Equals(null)))
            {
                p.SetNext(p.GetNext().GetNext());
            }
        }

        /// <summary>
        /// Print all data values in the linked list
        /// </summary>
        public void PrintList()
        {
            current = m_header;
            while (!(current.GetNext().Equals(null)))
            {
                Console.WriteLine(current.GetNext().GetData());
                current.SetNext(current.GetNext());
            }
            while (!(current == m_header));
        }

    }
}