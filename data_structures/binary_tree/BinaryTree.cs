using System;
using System.Collections.Generic;
using System.Linq;

namespace Structures
{
    class BinaryNode<T>
    {
        public T Value { get; set; }

        BinaryNode<T> parent = null;
        BinaryNode<T> left = null;
        BinaryNode<T> right = null;

        public BinaryNode<T> Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;

                if (value != null)
                {
                    left.parent = this;
                } 
            }
        }

        public T LeftValue
        {
            get
            {
                return left.Value;
            }
            set
            {
                if (left == null)
                {
                    left = new BinaryNode<T>(value);
                }
                else
                {
                    left.Value = value;
                }

                left = new BinaryNode<T>(value);
                left.parent = this;
            }
        }

        public BinaryNode<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;

                if(value != null)
                {
                    right.parent = this;
                }
            }
        }

        public T RightValue
        {
            get
            {
                return right.Value;
            }
            set
            {
                if (right == null)
                {
                    right = new BinaryNode<T>(value);
                }
                else
                {
                    right.Value = value;
                }

                right.parent = this;
            }
        }

        public BinaryNode<T> Parent
        {
            get
            {
                return this.parent;
            }
        }

        public int Weight
        {
            get
            {
                return GetWeight(this);
            }
        }

        public BinaryNode(T value)
        {
            this.Value = value;
            this.left = null;
            this.right = null;
        }

        public static BinaryNode<T> FindNode(T searchedValue, BinaryNode<T> node)
        {
            if(node == null)
            {
                return null;
            }

            if (Equals(searchedValue, node.Value))
            {
                return node;
            }

            BinaryNode<T> res1 = FindNode(searchedValue, node.Left);

            if(res1 != null)
            {
                return res1;
            }

            BinaryNode<T> res2 = FindNode(searchedValue, node.Right);

            if (res2 != null)
            {
                return res2;
            }

            return null;
        }

        protected static int GetWeight(BinaryNode<T> node)
        {
            if (node != null)
            {
                if (node.Left == null && node.Right == null)
                {
                    return 1;
                }
                else
                {
                    return GetWeight(node.Left) + GetWeight(node.Right) + 1;
                }
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }

    class BinaryTree<T>
    {
        public BinaryNode<T> Root { get; set; }

        public BinaryTree(T value)
        {
            this.Root = new BinaryNode<T>(value);
        }

        public BinaryTree(BinaryNode<T> node)
        {
            this.Root = node;
        }

        public int Depth
        {
            get
            {
                return DepthForNode(Root);
            }
        }

        public int Weight
        {
            get
            {
                return Root.Weight;
            }
        }

        public List<T> PreOrderTraversal
        {
            get
            {
                List<T> items = new List<T>();

                PreOrder(Root, items);

                return items;
            }
        }

        public List<T> PostOrderTraversal
        {
            get
            {
                List<T> items = new List<T>();

                PostOrder(Root, items);

                return items;
            }
        }

        public List<T> InOrderTraversal
        {
            get
            {
                List<T> items = new List<T>();

                InOrder(Root, items);

                return items;
            }
        }

        /*HELPER METHODS*/

        protected static void PreOrder(BinaryNode<T> node, List<T> buffer)
        {
            if (node == null)
            {
                return;
            }

            buffer.Add(node.Value);
            PreOrder(node.Left, buffer);
            PreOrder(node.Right, buffer);
        }

        protected static void PostOrder(BinaryNode<T> node, List<T> buffer)
        {
            if (node == null)
            {
                return;
            }

            PreOrder(node.Left, buffer);
            PreOrder(node.Right, buffer);
            buffer.Add(node.Value);
        }

        protected static void InOrder(BinaryNode<T> node, List<T> buffer)
        {
            if (node == null)
            {
                return;
            }

            PreOrder(node.Left, buffer);
            buffer.Add(node.Value);
            PreOrder(node.Right, buffer);
        }

        public int DepthForNode(BinaryNode<T> node)
        {
            int height = 0;

            if (node == null)
            {
                return -1;
            }

            BinaryNode<T> leftDecessor = node.Left;
            BinaryNode<T> rightDecessor = node.Right;

            int[] candidates = { height, DepthForNode(leftDecessor) + 1, DepthForNode(rightDecessor) + 1 };

            height = candidates.Max();

            return height;
        }

        protected static void ToBracketHelper(BinaryNode<T> node, ref string buffer)
        {
            buffer += "(" + node.Value.ToString();

            if (node.Left != null)
            {
                ToBracketHelper(node.Left, ref buffer);
            }

            if (node.Right != null)
            {
                ToBracketHelper(node.Right, ref buffer);
            }

            buffer += ")";
        }
        /*===================*/

        public string ToBracket()
        {
            string str = "";

            ToBracketHelper(Root, ref str);

            return str;
        }

        public void PrintTree(BinaryNode<T> node, int level)
        {
            if(node == null)
            {
                return;
            }

            string padLeft = "";
            int tmpLevel = level;

            while(tmpLevel-- > 0)
            {
                padLeft += " ";
            }

            if(node.Left != null || node.Right != null)
            {
                PrintTree(node.Right, level + 3);
            }

            Console.WriteLine(padLeft + node.Value);

            if (node.Left != null || node.Right != null)
            {
                PrintTree(node.Left, level + 3);
            }

        }

        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        public BinaryNode<T> GetNodeByPath(bool[] path)
        {
            BinaryNode<T> tmpNode = Root;

            for(int i = 0; i < path.Length; ++i)
            {
                tmpNode = path[i] ? tmpNode.Right : tmpNode.Left;
            }

            return tmpNode;
        }

        public BinaryNode<T> FindNode(T value)
        {
            return BinaryNode<T>.FindNode(value, Root);
        }
    }
}