using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Start
    {
        public static void Main()
        {
            DoublyLinkedList<int> d = new DoublyLinkedList<int>();
            d.addToEnd(1);
            d.addToEnd(2);
            d.addToEnd(3);
            d.addToEnd(4);
            d.PrintList();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
