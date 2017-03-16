using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class SmartBubbleSort
    {
        /// <summary>
        /// this is doing a smart bubble sort which will sort an array by comparing 
        /// the element by element sorting them until there is nothing to be sort
        /// but everytime when it's done with inner loop 
        /// it will make the array shorter by 1 
        /// </summary>
        /// <typeparam name="T">gerneric type</typeparam>
        /// <param name="array">an array</param>
        /// <returns>the sorted array</returns>
        public T[] BubbleSorting<T>(T[] array) where T : IComparable
        {
            //gets the length of the array
            int Length = array.Length;
            //the outer for loop is here to see how many times the inner for loop needs to run everytime the outer loop runs it will take away one number from the end of the array
            for (int outer = Length; outer >= 1; outer--)
            {
                //this inner for loop will run until the outer for loop stops so if(inner is smaller the outer it will stop running)
                for (int inner = 0; inner < outer - 1; inner++)
                {
                    //this will compare the objects
                    if (array[inner] != null && array[inner + 1] != null)
                    {
                        if (array[inner].CompareTo(array[inner + 1]) > 0)
                        {
                            //this T will hold the object we are using to compare
                            T Swap = array[inner];
                            //this will change the place of the object that is being used to compare with the one that it is compared with
                            array[inner] = array[inner + 1];
                            //this will change the place of the object to the place of the object that we are using to compare it to
                            array[inner + 1] = Swap;
                        }
                    }
                }
            }

            //returns the array
            return array;
        }


    }
}
