using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizedBinaryTree
{
    public interface IIndexedData<T,U> where U : IComparable
    {
        public T Data { get; set; }
        public U Index { get; set; }
        public IIndexedData<T,U>? Next { get; set; }
        public IIndexedData<T,U>? Previous { get; set; }

    }
}
