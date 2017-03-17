using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class Consoles:IComparable
    {
        //Variables
        private String consoleName;
        private String mediaType;
        private double price;

        //Constructers
        public Consoles()
        {
            consoleName = "";
            mediaType = "";
            price = 0;
        }

        public Consoles(String consoleName, String mediaType, double price)
        {
            this.consoleName = consoleName;
            this.mediaType = mediaType;
            this.price = price;
        }

        /// <summary>
        /// Console name variable getters and setters
        /// </summary>
        public String ConsoleName
        {
            get { return this.consoleName; }
            set { this.consoleName = value; }
        }

        /// <summary>
        /// Media type variable getters and setters
        /// </summary>
        public String MediaType
        {
            get { return this.mediaType; }
            set { this.mediaType = value; }
        }

        /// <summary>
        /// Price variable getters and setters
        /// </summary>
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        /// <summary>
        /// Compare to method of console objects
        /// </summary>
        /// <param name="obj">Which ever object is being compared</param>
        /// <returns>Int</returns>
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Consoles other = obj as Consoles;
            if (other != null)
                return this.price.CompareTo(other.price);
            else
                throw new ArgumentException("Object is not a Console");
        }


    }
}
