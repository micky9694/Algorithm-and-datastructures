using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Computer : System.IComparable
    {
        private int cores;
        private String brand;

        public Computer()
        {

        }

        public Computer(int cores,String brand)
        {
            this.cores = cores;
            this.brand = brand;
        }

        public int Cores
        {
            set
            {
                cores = value;
            }

            get
            {
                return cores;
            }
        }

        public String Brand
        {
            set
            {
                brand = value;
            }

            get
            {
                return brand;
            }
        }
        
        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }
            Computer other = obj as Computer;
            if (other != null)
                return this.cores.CompareTo(other.cores);
            else
                throw new ArgumentException("Object is not a Computer");
        }
    }
}
