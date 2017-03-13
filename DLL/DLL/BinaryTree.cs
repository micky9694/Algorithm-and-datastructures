using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class BinaryTree
    {
        public class Node<T>
        {
            private Node<T> left;
            private Node<T> right;
            private T node;

            public Node()
            {
                left = null;
                right = null;
            }

            public Node(T node)
            {
                left = null;
                right = null;
                this.node = node;
            }

            public T nodes
            {
                set
                {
                    node = value;
                }

                get
                {
                    return node;
                }
            }
        }


    }
}
