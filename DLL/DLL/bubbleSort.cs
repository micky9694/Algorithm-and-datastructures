using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class bubbleSort
    {
        /// <summary>
        /// this is doing a normal bubble sort which will sort an array by comparing 
        /// the element by element sorting them until there is nothing to be sort
        /// </summary>
        /// <typeparam name="T">gerneric type</typeparam>
        /// <param name="array">an array</param>
        /// <returns>the sorted array</returns>
        public T[] NormalBubbleSorting<T>(T[] array) where T : IComparable
        {
            //gets the length of the array
            int Length = array.Length;
            //a boolean so that the switch in the while loop would work
            Boolean sw = true;
            //a while loop to loop the for loop until theres nothing to sort anymore
            while (sw)
            {
                sw = false;

                for (int inner = 0; inner < Length - 1; inner++)
                {
                    //this will compare the objects
                    if (array[inner].CompareTo(array[inner + 1]) > 0)
                    {
                        //this T will hold the object we are using to compare
                        T Swap = array[inner];
                        //this will change the place of the object that is being used to compare with the one that it is compared with
                        array[inner] = array[inner + 1];
                        //this will change the place of the object to the place of the object that we are using to compare it to
                        array[inner + 1] = Swap;
                        sw = true;
                    }

                }
            }
            //returns the array
            return array;
        }
    }
}
