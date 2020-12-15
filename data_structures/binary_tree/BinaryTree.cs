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
                left.parent = this;
            }
        }

        public T LeftValue
        {
            get
            {
                return right.Value;
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
                right.parent = this;
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

        public BinaryNode(T value)
        {
            this.Value = value;
            this.left = null;
            this.right = null;
        }

        public static BinaryNode<T> FindNode(T searchedValue, BinaryNode<T> node)
        {
            if (Equals(searchedValue, node.Value))
            {
                return node;
            }

            else if (node.Left != null && node.Right != null)
            {
                BinaryNode<T> result = null;

                if (node.Left != null)
                {
                    result = FindNode(searchedValue, node.Left);
                }

                if (node.Right != null && result == null)
                {
                    result = FindNode(searchedValue, node.Right);
                }

                return result;

            }

            else
            {
                return null;
            }

        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }

    class BinaryTree<T>
    {
        public BinaryNode<T> root { get; set; }

        public int Depth
        {
            get
            {
                return DepthForNode(root);
            }
        }

        public List<T> PreOrderTraversal
        {
            get
            {
                List<T> items = new List<T>();

                PreOrder(root, items);

                return items;
            }
        }

        public List<T> PostOrderTraversal
        {
            get
            {
                List<T> items = new List<T>();

                PostOrder(root, items);

                return items;
            }
        }

        public List<T> InOrderTraversal
        {
            get
            {
                List<T> items = new List<T>();

                PostOrder(root, items);

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

        public BinaryTree(T value)
        {
            this.root = new BinaryNode<T>(value);
        }

        public BinaryTree(BinaryNode<T> node)
        {
            this.root = node;
        }

        public string ToBracket()
        {
            string str = "";

            ToBracketHelper(root, ref str);

            return str;
        }

        public BinaryNode<T> FindNode(T value)
        {
            return BinaryNode<T>.FindNode(value, root);
        }
    }
}