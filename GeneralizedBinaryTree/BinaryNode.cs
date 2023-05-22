using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralizedBinaryTree
{
    public class BinaryNode<T,U> : IBinaryNode<U> where U : IComparable
    {
        public object Left { get; set; }
        public object Right { get; set; }
        public U CalculatedIndexLeft { get; set; }
        public U CalculatedIndexRight { get; set; }

        public object NextNode(U searchValue)
        {
            if (Left is IBinaryNode<U> && CalculatedIndexLeft.CompareTo(searchValue) < 0)
            {
                return Left;
            } else if (Right is IBinaryNode<U> && CalculatedIndexRight.CompareTo(searchValue) > 0)
            {
                return Right;
            }
            throw new Exception($"Value \"{searchValue}\" not found.");
        }
    }
}
