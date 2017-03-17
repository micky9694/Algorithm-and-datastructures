using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Game
    {
        private double price;
        private String name;

        public Game()
        {

        }

        public Game(String gamename, double gamePrice)
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

            Game other = obj as Game;
            if (other != null)
                return this.price.CompareTo(other.price);
            else
                throw new ArgumentException("Object is not a Game");
        }
    }
}
