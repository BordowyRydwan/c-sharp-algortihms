﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class UnionFindNode
    {
        public UnionFindNode Parent { get; set; }
        public int Rank { get; set; }
    }


    class UnionFind
    {
        public void MakeSet(UnionFindNode UnionFindNode)
        {
            UnionFindNode.Parent = null;
            UnionFindNode.Rank = 0;
        }

        public UnionFindNode Find(UnionFindNode node)
        {
            if (node.Parent == null)
            {
                return node;
            }

            node.Parent = Find(node.Parent);

            return node.Parent;
        }

        public void Union(UnionFindNode node1, UnionFindNode node2)
        {
            UnionFindNode root1 = Find(node1);
            UnionFindNode root2 = Find(node2);

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
