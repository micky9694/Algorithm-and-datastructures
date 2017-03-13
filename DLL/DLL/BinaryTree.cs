using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Parent<T>
    {
        private Parent<T> left;
        private Parent<T> right;
        private T node;

        public Parent()
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
        }
    }

    class BinaryTree<T> where T : IComparable
    {
        private GArrayList<Parent<T>> tree;
        private int child;
        private int parentPos;
        public BinaryTree()
        {
            tree = new GArrayList<Parent<T>>();
            child = 0;
            parentPos = 0;
        }

        public void AddParent(Parent<T> p)
        {
            if(tree.Size() == 0)
            {
                tree.Add(p);
            }
            else
            {
                if(child % 2 == 0 && child != 0)
                {
                    parentPos++;
                    child = 0 ;
                }

                if (tree.Get(parentPos).Node != null)
                {
                    if (tree.Get(parentPos).getChildLeft() == null)
                    {
                        tree.Get(parentPos).setChildLeft(p);
                        tree.Add(p);
                        child++;
                    }
                    else
                    {
                        tree.Get(parentPos).setChildRight(p);
                        tree.Add(p);
                        child++;
                    }
                }
            }
            //Console.WriteLine(parentPos);
        }

        public Parent<T> getParent(int i)
        {
            return tree.Get(i);
        }
    }
}
