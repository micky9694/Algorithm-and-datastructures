using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Computer : IComparable<Computer>
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

        public int CompareTo(Computer other)
        {
            if (this.cores < other.cores)
            {
                return -1;
            }
            else if(this.cores > other.cores)
                {
                    return 1;
                }
            return 0;
        }
    }
}
