using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Choco: IComparable<Choco>
    {
        private string studentName;
        private int numberChocolates;
        private int compareTo;

        public Choco()
        { }

        public Choco(string studentName, int numberChocolates)
        {
            this.studentName = studentName;
            this.numberChocolates = numberChocolates;
        }

        public int ChocoNumber
        {
            get { return this.numberChocolates; }
            set { this.numberChocolates = value; }            
        }

        public int CompareTo(Choco other)
        {
            compareTo = 0;
            if (this.numberChocolates < other.numberChocolates)
            {
                compareTo = -1;
            }
            else if (this.numberChocolates > other.numberChocolates)
            {
                compareTo = 1;
            }
            return compareTo;
        }
    }
}
