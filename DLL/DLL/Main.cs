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

            Stack<int> q = new Stack<int>();
            q.push(1);
            q.push(2);
            q.push(3);
            q.push(4);
            q.printStack();
            Computer[] cs = new Computer[5];
            cs[0] = new Computer(2, "Asus");
            cs[1] = new Computer(10, "Asus");
            cs[2] = new Computer(6, "Asus");
            cs[3] = new Computer(1, "Asus");
            cs[4] = new Computer(3, "Asus");
            Choco[] c = new Choco[3];
            c[0] = new Choco("Monica", 5);
            c[1] = new Choco("Monica", 10);
            c[2] = new Choco("Monica", 1);
            Console.WriteLine();
            SmartBubbleSort sbs = new SmartBubbleSort();
            c = sbs.BubbleSorting(c);
            for(int i = 0; i < 3; i++)
            {
                Console.Write(c[i].ChocoNumber+" ");
            }
            Console.ReadKey();
        }
    }
}
