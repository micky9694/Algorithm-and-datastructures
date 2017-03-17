using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Games
    {
        private double price;
        private String name;

        public Games()
        {

        }

        public Games(String gamename, double gamePrice)
        {
            name = gamename;
            price = gamePrice;
        }

        public String GameName
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double GamePrice
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Games other = obj as Games;
            if (other != null)
                return this.price.CompareTo(other.price);
            else
                throw new ArgumentException("Object is not a Game");
        }
    }
}
