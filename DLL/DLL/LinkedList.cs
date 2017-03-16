using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{

    /// <summary>
    /// This class is the actual linked list where nodes are added in as the user wishes.
    /// </summary>
    /// <typeparam name="T">Genreic field</typeparam>
    public class LinkedList<T> where T:IComparable<T>
    {
        //Variables used throughout the linked list document
        private SingularLinkNode<T> m_header;
        private SingularLinkNode<T> current;

        //Constructers start
        public LinkedList()
        {
            m_header = new SingularLinkNode<T>();
            current = new SingularLinkNode<T>();
        }
        public LinkedList(T item)
        {
            m_header = new SingularLinkNode<T>(item);
            current = new SingularLinkNode<T>();
        }
        //Constructers end

        /// <summary>
        /// This private method is used to run a search through the linked list to find an object specified in Item
        /// </summary>
        /// <param name="Item">Generic object that is searched for in the Linked list</param>
        /// <returns>Generic node used in other methods</returns>
        private SingularLinkNode<T> Find(T Item)
        {
            current = m_header;
            while((!current.getData().Equals(Item))&&(!(current.getNext() ==null)))
            {
                current = current.getNext();
            }
            if(!current.getData().Equals(Item))
            {
                current = null;
            }
            return current;
        }

        /// <summary>
        /// Same concept as above Find except that it finds the previous node to the one in Item
        /// </summary>
        /// <param name="Item">Genreic field used in the search</param>
        /// <returns>return node</returns>
        private SingularLinkNode<T> FindPrevious(T Item)
        {
            current = m_header;
            while((!(current.getNext() == null))&&(!current.getNext().getData().Equals(Item)))
            {
                current = current.getNext();
            }
            return current;
        }
        /// <summary>
        /// Method used to add node to end of the linked list
        /// </summary>
        /// <param name="newItem">The Item being added to the end of the linked list</param>
        public void AddToEnd(T newItem)
        {
            current = m_header;
            SingularLinkNode<T> newNode = new SingularLinkNode<T>(newItem);
            
            while(!(current.getNext() == null))
            {
                current = current.getNext();
            }

            current.setNext(newNode);
        }

        /// <summary>
        /// Insert used to add an Item anywhere into the list after any given value
        /// </summary>
        /// <param name="newItem">New Item being added into the linked list</param>
        /// <param name="after">After this value the new Item will be added</param>
        public void Insert(T newItem, T after)
        {
            SingularLinkNode<T> newNode = new SingularLinkNode<T>(newItem);

            current = Find(after);
            newNode.setNext(current.getNext());
            current.setNext(newNode);
        }

        /// <summary>
        /// This method will remove the given Item from the list and ajust all links
        /// </summary>
        /// <param name="Item">Item to be removed</param>
        public void Remove(T Item)
        {
            SingularLinkNode<T> p = FindPrevious(Item);
            if(!(p.getNext() == null))
            {
                p.setNext(p.getNext().getNext());
            }
        }

        /// <summary>
        /// Print all data values in the linked list
        /// </summary>
        public void PrintList()
        {
            current = m_header;
            while(!(current.getNext() == null))
            {
                Console.WriteLine(current.getNext().getData());
                current =current.getNext();
            }
        }
    }
}
