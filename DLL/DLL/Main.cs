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
            
            GArrayList<Consoles> conList = new GArrayList<Consoles>();
            conList.Add(new Consoles("ps2", "Disc", 200.0));
            conList.Add(new Consoles("ps3", "Disc", 400.0));
            conList.Add(new Consoles("ps4", "Disc", 600.0));
            conList.Add(new Consoles("Switch", "Cartridge", 300.0));
            conList.Add(new Consoles("3DS", "Cartridge", 200.0));
            Console.WriteLine();
            SmartBubbleSort sbs = new SmartBubbleSort();
            conList = sbs.BubbleSorting(conList);
            for(int i = 0; i < conList.Size(); i++)
            {
                Console.Write(conList.Get(i).ConsoleName+" ");
            }
            Console.ReadKey();
            
            GArrayList<>
        }
    }
}
