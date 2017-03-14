using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    class DoubleNode<T> where T : IComparable<T>
    {
        private T Data;
        private DoubleNode<T> Next;
        private DoubleNode<T> Prev;

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

        public DoubleNode<T> GetNext()
        {
            return Next;
        }

        public void SetNext(DoubleNode<T> next)
        {
            Next = next;
        }

        public DoubleNode<T> GetPrev()
        {
            return Prev;
        }

        public void SetPrev(DoubleNode<T> Prev)
        {
            this.Prev = Prev;
        }

        public void AddData(T Data)
        {
            this.Data = Data;
        }

        public T GetData()
        {
            return Data;
        }
    }
}
