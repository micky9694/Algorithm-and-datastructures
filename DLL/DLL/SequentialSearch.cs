using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class SequentialSearch
    {
        /// <summary>
        ///  Sequnetial Search is an algorithm that search element by element in an array
        ///  till finds the desired element
        /// </summary>
        /// <typeparam name="T"> Generic type</typeparam>
        /// <param name="array"> Array given by user/program</param>
        /// <param name="element"> The element to be found</param>
        /// <returns></returns>
        public Boolean sequentialSearch<T>(T[] array, T element) where T : IComparable
        {
            Boolean sw = true; // switch to stop the loop from running 
            int size = array.Length;  // geting the size of the array
            for (int i = 0; i < size && sw; i++) //looping through the array
            {
                if (array[i].Equals(element)) //checking if is the element 
                {
                    sw = false; // if yes then stop the loop
                    return true; // return true
                }
            }
            return false; // after finishing the loop the element wasn't detected return false
        }
    }
}
