using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    /// <summary>
    /// This class is used to create each node in the Linked list.
    /// It is also Generic and I comparable
    /// </summary>
    /// <typeparam name="T">Generic Value that can be used for any data type</typeparam>
    class SingularLinkNode<T> where T : IComparable<T>
    {
        private T Data;//This is the actual data stored in the node
        private SingularLinkNode<T> Next;//This is the link to the next node

        /// <summary>
        /// Constructers of the nodes
        /// </summary>
        public SingularLinkNode()
        {
            Data = default(T);
            Next = null;
        }

        public SingularLinkNode(T Data)
        {
            this.Data = Data;
            Next = null;
        }

        /// <summary>
        /// Get next node
        /// </summary>
        /// <returns>Genreic value</returns>
        public SingularLinkNode<T> GetNext()
        {
            return Next;
        }

        /// <summary>
        /// Sets the link to a next node
        /// </summary>
        /// <param name="next">The value of next</param>
        public void SetNext(SingularLinkNode<T> next)
        {
            Next = next;
        }

        /// <summary>
        /// Add data to a created node
        /// </summary>
        /// <param name="Data">Data to be added</param>
        public void AddData(T Data)
        {
            this.Data = Data;
        }
        /// <summary>
        /// Return data that is stored in each node
        /// </summary>
        /// <returns>genreic data</returns>
        public T GetData()
        {
            return Data;
        }
    }
}
