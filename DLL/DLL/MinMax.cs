using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class MinMax
    {
        /// <summary>
        ///  Three function that calculates: 
        ///         - min
        ///         - max
        ///         - min and max
        /// </summary>
        /// <typeparam name="T"> Generic type </typeparam>
        /// <param name="array"> Array given by user/program </param>
        /// <returns> retunr min, returns max, returns min and max in array form </returns>
        public T Min<T>(T[] array) where T : IComparable
        {
            T min = array[0]; // initializing the minim with the first element of the array
            int size = array.Length; // geting the size of the array
            for (int i = 1; i < size; i++) //looping through the array
            {
                if (array[i].CompareTo(min) < 0) // if minimum initialized is bigger than the next element
                {
                    min = array[i]; // then minimum takes the value of the next element
                }
            }

            return min; // returns min 
        }

        public T Max<T>(T[] array) where T : IComparable
        {
            T max = array[0]; //initializing the max of the array as the first element of the array
            int size = array.Length; // geting the size of the array
            for (int i = 1; i < size; i++)//looping through the array
            {
                if (array[i].CompareTo(max) > 0) // if maximum initialized is lower than the next element 
                {
                    max = array[i]; // then maximum takes the value of the next element
                }
            }

            return max;
        }

        public T[] Min_Max<T>(T[] array) where T : IComparable
        {
            T[] minMax = { array[0], array[0] }; //initalize the index 0 and 1 with the first element of the array
            int size = array.Length; // geting the size of the array
            for (int i = 1; i < size; i++) //looping through the array
            {
                if (array[i].CompareTo(minMax[0]) < 0) //checking if the index 0 of minMax is bigger than the next element
                {
                    minMax[0] = array[i]; // if yes minMax index 0 takes the value of the next element
                }

                if (array[i].CompareTo(minMax[1]) > 0)//checking if the index 1 of minMax is lower than the next element
                {
                    minMax[1] = array[i]; // if yes minMax index 1 takes the value of the next element
                }
            }

            return minMax;
        }
    }
}
