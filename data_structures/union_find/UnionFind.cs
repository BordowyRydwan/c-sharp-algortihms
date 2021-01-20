using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class UnionFindNode<T>
    {
        public UnionFindNode<T> Parent { get; set; }
        public T Value { get; set; }
        public int Rank { get; set; }
    }

    class UnionFind<T>
    {
        public void MakeSet(UnionFindNode<T> UnionFindNode)
        {
            UnionFindNode.Parent = null;
            UnionFindNode.Rank = 0;
        }

        public UnionFindNode<T> Find(UnionFindNode<T> node)
        {
            if (node.Parent == null)
            {
                return node;
            }

            node.Parent = Find(node.Parent);

            return node.Parent;
        }

        public void Union(UnionFindNode<T> node1, UnionFindNode<T> node2)
        {
            UnionFindNode<T> root1 = Find(node1);
            UnionFindNode<T> root2 = Find(node2);

            if (root1.Rank > root2.Rank)
            {
                root2.Parent = root1;
            }
            else if (root1.Rank < root2.Rank)
            {
                root1.Parent = root2;
            }
            else if (root1 != root2)
            {
                root2.Parent = root1;
                root1.Rank++;
            }
        }
    }
}
