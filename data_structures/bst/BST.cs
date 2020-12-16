using System;
using System.Collections.Generic;

namespace Structures
{
    class BST<T> : BinaryTree<T> where T : IComparable<T>
    {
        public BST(T value) : base(value) { }
        public BST(BinaryNode<T> value) : base(value) { }

        public BinaryNode<T> MaxElement
        {
            get
            {
                BinaryNode<T> tmpNode = Root;

                while (tmpNode.Right != null)
                {
                    tmpNode = tmpNode.Right;
                }

                return tmpNode;
            }
        }

        public BinaryNode<T> MinElement
        {
            get
            {
                BinaryNode<T> tmpNode = Root;

                while (tmpNode.Left != null)
                {
                    tmpNode = tmpNode.Left;
                }

                return tmpNode;
            }
        }

        public void Insert(BinaryNode<T> node)
        {
            if(Root == null)
            {
                Root = node;
            }
            else
            {
                BinaryNode<T> tmpNode = Root;

                while(tmpNode != null)
                {
                    if(tmpNode.Value.CompareTo(node.Value) >= 0)
                    {
                        if(tmpNode.Left != null)
                        {
                            tmpNode = tmpNode.Left;
                        }
                        else
                        {
                            tmpNode.Left = node;
                            return;
                        }
                    }
                    else
                    {
                        if (tmpNode.Right != null)
                        {
                            tmpNode = tmpNode.Right;
                        }
                        else
                        {
                            tmpNode.Right = node;
                            return;
                        }
                    }
                }
            }
        }

        public void Insert(T value) => Insert(new BinaryNode<T>(value));

        public void Delete(BinaryNode<T> node)
        {
            if(node.Left == null && node.Right == null)
            {
                if(Equals(node.Parent.LeftValue, node.Value))
                {
                    node.Parent.Left = null;
                }
                else
                {
                    node.Parent.Right = null;
                }

                return;
            }
   
            if(node.Left == null)
            {
                node.Value = node.RightValue;
                node.Right = null;
                return;
            }

            if (node.Right == null)
            {
                node.Value = node.LeftValue;
                node.Left = null;
                return;
            }

            BinaryNode<T> successor = Successor(node);

            node.Value = successor.Value;
            Delete(successor);
        }

        public void Delete(T value)
        {
            BinaryNode<T> searchedNode = FindNode(value);

            Delete(searchedNode);
        }

        public bool[] GetPathTo(T value)
        {
            BinaryNode<T> tmpNode = Root;
            List<bool> path = new List<bool>();

            while(value.CompareTo(tmpNode.Value) != 0)
            {
                if(tmpNode == null)
                {
                    return new bool[0];
                }

                if (value.CompareTo(tmpNode.Value) == 1)
                {
                    path.Add(true);
                    tmpNode = tmpNode.Right;
                    continue;
                }

                if (value.CompareTo(tmpNode.Value) == -1)
                {
                    path.Add(false);
                    tmpNode = tmpNode.Left;
                    continue;
                }
            }

            return path.ToArray();
        }

        public void RotateLeft(BinaryNode<T> node)
        {
            if(node.Right == null)
            {
                Console.WriteLine("Could not do left rotation");
                return;
            }

            BinaryNode<T> tmpNode = new BinaryNode<T>(node.Value);

            tmpNode.Left = node.Left;
            tmpNode.Right = node.Right.Left;

            node.Value = node.Right.Value;
            node.Left = tmpNode;
            node.Right = node.Right.Right;
        }

        public void RotateRight(BinaryNode<T> node)
        {
            if (node.Left == null)
            {
                Console.WriteLine("Could not do right rotation");
                return;
            }

            BinaryNode<T> tmpNode = new BinaryNode<T>(node.Value);

            tmpNode.Left = node.Left.Right;
            tmpNode.Right = node.Right;

            node.Value = node.Left.Value;
            node.Right = tmpNode;
            node.Left = node.Left.Left;
        }

        protected void Partition(BinaryNode<T> node, int controlWeight)
        {
            int leftWeight = node.Left == null ? 0 : node.Left.Weight;

            if(leftWeight > controlWeight)
            {
                Partition(node.Left, controlWeight);
                RotateRight(node);
            }

            if(leftWeight < controlWeight)
            {
                Partition(node.Right, controlWeight - leftWeight - 1);
                RotateLeft(node);
            }
        }

        protected void EqualizeTree(BinaryNode<T> node)
        {
            if(node == null)
            {
                return;
            }

            if(node.Weight == 1)
            {
                return;
            }

            Partition(node, node.Weight / 2);
            EqualizeTree(node.Left);
            EqualizeTree(node.Right);
        }

        protected BinaryNode<T> Successor(BinaryNode<T> rootNode, BinaryNode<T> node)
        {
            if(Equals(rootNode.Value, node.Value))
            {
                BST<T> tmp = new BST<T>(rootNode.Right);

                return tmp.MinElement;
            }

            if(rootNode.Value.CompareTo(node.Value) == 1)
            {
                return Successor(rootNode.Left, node);
            }
            else
            {
                return Successor(rootNode.Right, node);
            }
        }

        public BinaryNode<T> Successor(BinaryNode<T> node)
        {
            return Successor(Root, node);
        }

        protected BinaryNode<T> Decessor(BinaryNode<T> rootNode, BinaryNode<T> node)
        {
            if (Equals(rootNode.Value, node.Value))
            {
                BST<T> tmp = new BST<T>(rootNode.Left);

                return tmp.MaxElement;
            }

            if (rootNode.Value.CompareTo(node.Value) == 1)
            {
                return Decessor(rootNode.Left, node);
            }
            else
            {
                return Decessor(rootNode.Right, node);
            }
        }

        public BinaryNode<T> Decessor(BinaryNode<T> node)
        {
            return Decessor(Root, node);
        }

        public void Equalize()
        {
            EqualizeTree(Root);
        }
    }
}
