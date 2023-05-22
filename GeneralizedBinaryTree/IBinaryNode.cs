using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizedBinaryTree
{
    public interface IBinaryNode<U> where U : IComparable
    {
        public object Right { get; set; }
        public object Left { get; set; }
        public U CalculatedIndexLeft { get; set; }
        public U CalculatedIndexRight { get; set; }
        public object NextNode(U searchValue);
    }
}
