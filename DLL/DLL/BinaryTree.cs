using DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode<T> Left;
        public BinaryTreeNode<T> Right;
        public T Node;

        /*public Parent()
        {
            left = null;
            right = null;
            node = default(T);
        }

        public Parent(T node)
        {
            left = null;
            right = null;
            this.node = node;
        }
        
        public T Node
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

        public void setChildLeft(Parent<T> left)
        {
            this.left = left;
        }

        public void setChildRight(Parent<T> right)
        {
            this.right = right;
        }

        public Parent<T> getChildLeft()
        {
            return left;
        }

        public Parent<T> getChildRight()
        {
            return right;
        } */
        public void DisplayNode()
        {
            Console.Write(Node + " ");
        }
    }

    class BinaryTree<T> where T : IComparable
    {
        private GArrayList<BinaryTreeNode<T>> tree;
        private GArrayList<GArrayList<BinaryTreeNode<T>>> matrics;
        private int child;
        private int parentPos;
        public BinaryTreeNode<T> root;
        private BinaryTreeNode<T> current;
        public BinaryTree()
        {
            tree = new GArrayList<BinaryTreeNode<T>>();
            matrics = new GArrayList<GArrayList<BinaryTreeNode<T>>>();
            child = 0;
            parentPos = 0;
            root = null;
        }

        public void Add(T data)
        {
            BinaryTreeNode<T> newN = new BinaryTreeNode<T>();
            newN.Node = data;
            BinaryTreeNode<T> current = root, parent = null;
            while (current != null)
            {
                int result = current.Node.CompareTo(data);
                if (result == 0)
                    // they are equal - attempting to enter a duplicate - do nothing
                    return;
                else if (result > 0)
                {
                    // current.Value > data, must add n to current's left subtree
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // current.Value < data, must add n to current's right subtree
                    parent = current;
                    current = current.Right;
                }
            }

            if (parent == null)
                // the tree was empty, make n the root
                root = newN;
            else
            {
                int result = parent.Node.CompareTo(data);
                if (result > 0)
                    // parent.Value > data, therefore n must be added to the left subtree
                    parent.Left = newN;
                else
                    // parent.Value < data, therefore n must be added to the right subtree
                    parent.Right = newN;
            }
        }

        private BinaryTreeNode<T> getParent(int i)
        {
            return tree.Get(i);
        }

        public void InOrder(BinaryTreeNode<T> theRoot)
        {
            if(theRoot != null)
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }

        public void PreOrder(BinaryTreeNode<T> theRoot)
        {
            if(theRoot != null)
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }

        public void PostOrder(BinaryTreeNode<T> theRoot)
        {
            if (theRoot != null)
            {
                PostOrder(theRoot.Left);
                PostOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }
    }
}
