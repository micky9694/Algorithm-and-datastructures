using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    /// <summary>
    /// this class is used for creating nodes 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class DoubleNode<T> where T : IComparable<T>
    {
        /// <summary>
        /// Variables used for all nodes
        /// </summary>
        private T Data;
        private DoubleNode<T> Next;
        private DoubleNode<T> Prev;

        /// <summary>
        /// Constructers
        /// </summary>
        public DoubleNode()
        {
            Data = default(T);
            Next = null;
            Prev = null;
        }
        public DoubleNode(T Data)
        {
            this.Data = Data;
            Next = null;
            Prev = null;
        }

        /// <summary>
        /// Get the next stored node
        /// </summary>
        /// <returns>Next double link node</returns>
        public DoubleNode<T> GetNext()
        {
            return Next;
        }
        /// <summary>
        /// Sets the next linked node
        /// </summary>
        /// <param name="next">The object used to be set as next</param>
        public void SetNext(DoubleNode<T> next)
        {
            Next = next;
        }
        /// <summary>
        /// Get the previous linked object
        /// </summary>
        /// <returns>The object that is set as previous</returns>
        public DoubleNode<T> GetPrev()
        {
            return Prev;
        }
        /// <summary>
        /// Sets the previous object that is linked to the node
        /// </summary>
        /// <param name="Prev">The object to be set as previous</param>
        public void SetPrev(DoubleNode<T> Prev)
        {
            this.Prev = Prev;
        }
        /// <summary>
        /// Add the data value to the Node
        /// </summary>
        /// <param name="Data">The value being added</param>
        public void AddData(T Data)
        {
            this.Data = Data;
        }
        /// <summary>
        /// returning the data value of the node
        /// </summary>
        /// <returns>The data value of the node</returns>
        public T GetData()
        {
            return Data;
        }
    }
}
