using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DLL.GArrayList<string> list = new DLL.GArrayList<string>();

            list.Add("Hoi");
            list.Add("ik");
            list.Add("ben");
            list.Add("Micky");

            list.Insert(1, "daar");
            list.Remove(1);

            foreach (string item in list)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
    }
}
