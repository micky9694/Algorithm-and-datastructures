using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Node<K,T> where K:IComparable<K>
    {
        public K Key;
        public T Item;
        public Node<K, T> NextNode;

        public Node()
        {
            Key = default(K);
            Item = default(T);
            NextNode = null;
        }

        public Node(K key, T item, Node<K,T> nextNode)
        {
            Key = key;
            Item = item;
            NextNode = nextNode; 
        }
    }
    public class LinkedList<K,T> where K:IComparable<K>
    {
        Node<K, T> m_Head;
        public LinkedList()
        {
            m_Head = new Node<K, T>();
        }
        public void AddHead(K key,T item)
        {
            Node<K, T> newNode = new Node<K, T>(key,item,m_Head.NextNode);
            m_Head.NextNode = newNode;
        }

       /* T Find(K key)
        {
            Node<K, T> current = m_Head;
            while ((current.NextNode != null)&&(current.Key.CompareTo(key) != 0))
            {
                current = current.NextNode;
            }
            return current.Item;
        }*/
    }
}
