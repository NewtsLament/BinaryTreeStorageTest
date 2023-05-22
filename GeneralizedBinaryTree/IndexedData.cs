using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizedBinaryTree
{
    public class IndexedData<T,U> : IIndexedData<T,U> where U : IComparable
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        private U index;

        public U Index
        {
            get { return index; }
            set { index = value; }
        }

        public IIndexedData<T,U>? Next { get; set; }
        public IIndexedData<T,U>? Previous { get; set; }
    }
}
