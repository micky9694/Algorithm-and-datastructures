using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class BinarySearch
    {
        /// <summary>
        /// Input: the array needs to be already sorted 
        /// Unsing a recursive function is searching for the element 
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="array">Array given by the user/program</param>
        /// <param name="element">The element to be found</param>
        /// <param name="start">Where the search starts</param>
        /// <param name="end">Where the search ends</param>
        /// <returns></returns>
        private Boolean Search<T>(T[] array, T element, double start, double end) where T : IComparable
        {
            // If the starting point is bigger then the ending point or the ending point is smaller then the starting point
            // There is no element to be found
            if (start <= end)
            {
                int m = (int)Math.Round((start + end) / 2); // Here is calculated the middle index of the array 
                if (array[m].Equals(element)) //If the middle element of the array is the element that we are searching for then we found it
                {
                    return true;
                }
                else if (array[m].CompareTo(element) < 0) //If not then is checking if the element is on the right side of the array 
                {
                    start = (double)(m + 1);
                    return Search(array, element, start, end); // splits the array in half and searches in the right part
                }
                else //if not 
                {
                    end = (double)(m - 1);
                    return Search(array, element, start, end); // splits the array in half and searches in the left part 
                }
            }
            else // if there is no element found display
            {
                return false;
            }

        }
        /// <summary>
        ///  This function is used for getting the array from the main program
        ///  Here is calculated the size of the array and passed forward to the function that does all the work Search
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="array">The array gived by the user needs to be already sorted</param>
        /// <param name="element">The element to be found</param>
        /// <returns></returns>

        public Boolean binarySearch<T>(T[] array, T element) where T : IComparable
        {
            double size = array.Length - 1;
            return Search(array, element, 0, size);
        }
    }
}
