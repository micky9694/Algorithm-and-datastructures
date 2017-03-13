using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class BucketHashing <T>
    {
        private const int size = 101;
        //add arrayList 
        ArrayList[] data;

        public BucketHashing()
        {
            data = new ArrayList[size];
            for (int i = 0; i<=size-1; i++)
            {
                data[i] = new ArrayList(4);
            }
        }

        public int Hash(String a)
        {
            long tot = 0;
            char[] charray;
            charray = a.ToCharArray();
            int length = a.Length;
            for (int i = 0; i<= length-1;i++)
            {
                tot += 37 * tot + (int)charray[i];
            }
            tot = tot % data.GetUpperBound(0);
            if(tot<0)
            {
                tot += data.GetUpperBound(0);
            }
            return (int)tot;
        }

        public void Insert (String item)
        {
            /*bool found = false;
            int i = 0;
            while ((i<size) && (found == false))
            {
                if(data[i].Equals(item))
                {
                    found = true;
                }
                i++;
            }
            if (found == true)
            {
                data[size] = item;
            }
            else
            {
                Console.Write("The item is already in the bucket.");
            } */
            int hash_value;
            hash_value = Hash(value);
            
        }

        public void Remove (String item)
        {
            bool found = false;
            int place = 0;
            int i = 0;
            while ((i<size)&&(found==false))
                {
                if (data[i].Equals(item))
                {
                    found = true;
                    place = i;
                }
                i++;
            }
            if (found == true)
            {
                for (i = place; i<size; i++)
                {
                    data[place] = data[place + 1];
                }
                size -= 1;
            }
        }
    }
}
