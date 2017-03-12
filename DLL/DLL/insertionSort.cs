using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class InsertionSort
    {
        /// <summary>
        /// Insertion sort is a simple sorting algorithm that builds the 
        /// final sorted array (or list) one item at a time. It is much 
        /// less efficient on large lists than more advanced algorithms 
        /// such as quicksort, heapsort, or merge sort.
        /// </summary>
        /// <typeparam name="T">gerneric type</typeparam>
        /// <param name="array">an array</param>
        /// <returns>the sorted array</returns>
        public T[] InsertionSorting<T>(T[] array) where T : IComparable
        {
            //this for loop runs the while loop as many time as there is objects in the array
            for (int counter = 0; counter < array.Length - 1; counter++)
            {
                //index so that we can compare the objects in the array
                int index = counter + 1;
                //the while loop so that we can compare the all objects in the array
                while (index > 0)
                {
                    //this if compares the object in the array and changes the places if needed
                    if (array[index - 1].CompareTo(array[index]) > 0)
                    {
                        //hold the object for the time
                        T Swap = array[index - 1];
                        //changes the placeing of the object we use to compare
                        array[index - 1] = array[index];
                        //changes the place of the object with we put on hold just now
                        array[index] = Swap;
                    }
                    //lowers the index so this does not become an infinte loop
                    index--;
                }
            }
            //returns the array
            return array;
        }
    }
}
