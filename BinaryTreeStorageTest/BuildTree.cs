using GeneralizedBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeStorageTest
{
    internal class BuildIntegerIndexedStringTree
    {
        private string[] values;
        public BuildIntegerIndexedStringTree SetArray(string[] values)
        {
            this.values = values;
            return this;
        }
        public IBinaryNode<uint> Build()
        {
            IIndexedData<string,uint> current = new IndexedData<string,uint>();
            List<IIndexedData<string,uint>> list = new List<IIndexedData<string,uint>>();
            for (int i = 0; i < values.Length; i++)
            {
                var item = values[i];
                current.Data = item;
                current.Index = (uint)i;
                list.Add(current);
                if (i < values.Length - 1)
                {
                    current.Next = new IndexedData<string,uint>();
                    current.Next.Previous = current;
                    current = current.Next;
                }
            }
            BinaryNode<string,uint> root = new BinaryNode<string,uint>();
            RecursiveTreeTraversal(list, root);
            return root;
        }
        private void RecursiveTreeTraversal(List<IIndexedData<string,uint>> binaryList, IBinaryNode<uint> lastNode)
        {
            int n = Convert.ToInt32(Math.Floor((binaryList.Count) / 2.0));
            List<IIndexedData<string, uint>> left = binaryList.GetRange(0, n);
            List<IIndexedData<string, uint>> right = binaryList.GetRange(n, binaryList.Count-n);
            if (left.Count == 1)
            {
                lastNode.Left = left.First();
                lastNode.CalculatedIndexLeft = left.First().Index;
            } else
            {
                lastNode.Left = new BinaryNode<string, uint>();
                lastNode.CalculatedIndexLeft = left.Last().Index;
                RecursiveTreeTraversal(left, lastNode.Left as IBinaryNode<uint>);
            }
            if (right.Count == 1)
            {
                lastNode.Right = right.First();
                lastNode.CalculatedIndexRight = right.First().Index;
            }
            else
            {
                lastNode.Right = new BinaryNode<string, uint>();
                lastNode.CalculatedIndexRight = right.First().Index;
                RecursiveTreeTraversal(right, lastNode.Right as IBinaryNode<uint>);
            }
        }
    }
}
