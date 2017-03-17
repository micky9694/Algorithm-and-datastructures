using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Choco: IComparable
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

        public int CompareTo(object obj)
        {
            if(obj == null)
            {
                return 1;
            }

            Choco other = obj as Choco;
            if (other != null)
                return this.ChocoNumber.CompareTo(other.ChocoNumber);
            else
                throw new ArgumentException("Object is not a Choco, it's a korok seed gift");
        }
    }
}
