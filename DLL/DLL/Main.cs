using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Start
    {
        public static void Main()
        {
            Console.WriteLine("Inorder transversal: ");
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(23);
            bt.Add(45);
            bt.Add(16);
            bt.Add(37);
            bt.Add(3);
            bt.Add(99);
            bt.Add(22);
            bt.InOrder(bt.root);
            Console.WriteLine();
            bt.PostOrder(bt.root);
            Console.WriteLine();
            bt.PreOrder(bt.root);
            Console.ReadKey();
        }
    }
}
