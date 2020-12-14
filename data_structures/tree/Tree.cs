using System;
using System.Collections.Generic;

namespace Structures
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> parent = null;
        public List<Node<T>> children { get; }

        public Node(T value)
        {
            Value = value;
            children = new List<Node<T>>();
        }

        public void AddChild(T value)
        {
            Node<T> tmpNode = new Node<T>(value);
            tmpNode.parent = this;

            children.Add(tmpNode);
        }

        public void AddChildNode(Node<T> node)
        {
            node.parent = this;
            children.Add(node);
        }

        public bool IsRoot()
        {
            return parent == null;
        }

        public static Node<T> FindNode(T searchedValue, Node<T> node)
        {
            if (Equals(searchedValue, node.Value))
            {
                return node;
            }

            for (int i = 0; i < node.children.Count; ++i)
            {
                Node<T> searchedNode = FindNode(searchedValue, node.children[i]);

                if (Equals(searchedValue, searchedNode.Value))
                {
                    return searchedNode;
                }
            }

            return new Node<T>(default(T));
        }
    }

    class Tree<T>
    {
        public Node<T> root { get; }

        /*PROPERTIES*/
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

        /*CONSTRUCTORS*/

        public Tree(T value)
        {
            this.root = new Node<T>(value);
        }

        public Tree(Node<T> node)
        {
            this.root = node;
        }

        public Tree(string bracketTree)
        {
            Node<T> tmpNode = new Node<T>(default(T));
            InsertChildren_Bracket(bracketTree, tmpNode);

            root = tmpNode.children[0];
        }

        /*HELPER METHODS*/

        protected static void InsertChildren_Bracket(string bracketTree, Node<T> node)
        {
            if (bracketTree.Length == 1)
            {
                return;
            }

            List<string> children = new List<string>();
            List<int> leftBrackets = new List<int>(); 
            List<int> rightBrackets = new List<int>(); 

            int leftCounter = 0;
            int rightCounter = 0;

            for(int i = 0; i < bracketTree.Length; ++i)
            {
                if(bracketTree[i] == '(')
                {
                    leftCounter++;
                    leftBrackets.Add(i);

                    while (leftCounter != rightCounter)
                    {
                        i++;

                        if(bracketTree[i] == '(')
                        {
                            leftCounter++;
                        }

                        if (bracketTree[i] == ')')
                        {
                            rightCounter++;
                        }
                    }

                    rightBrackets.Add(i);
                }

                leftCounter = 0;
                rightCounter = 0;
            }

            for (int i = 0; i < leftBrackets.Count; ++i)
            {
                string child = bracketTree.Substring(leftBrackets[i] + 1, rightBrackets[i] - leftBrackets[i] - 1);

                children.Add(child);
            }

            for (int i = 0; i < children.Count; ++i)
            {
                T childValue = (T)(object)children[i][0];
                node.AddChild(childValue);
            }

            for (int i = 0; i < node.children.Count; ++i)
            {
                InsertChildren_Bracket(children[i], node.children[i]);
            }
        }

        protected static void PreOrder(Node<T> node, List<T> buffer)
        {
            buffer.Add(node.Value);

            if (node.children.Count > 0)
            {
                for (int i = 0; i < node.children.Count; ++i)
                {
                    PreOrder(node.children[i], buffer);
                }
            }
        }

        protected static void PostOrder(Node<T> node, List<T> buffer)
        {
            if (node.children.Count > 0)
            {
                for (int i = 0; i < node.children.Count; ++i)
                {
                    PostOrder(node.children[i], buffer);
                }
            }

            buffer.Add(node.Value);
        }

        protected static void ToBracketHelper(Node<T> node, ref string buffer)
        {
            buffer += "(" + node.Value.ToString();

            if (node.children.Count > 0)
            {
                for (int i = 0; i < node.children.Count; ++i)
                {
                    ToBracketHelper(node.children[i], ref buffer);
                }
            }

            buffer += ")";
        }

        /*TREE METHODS*/

        public int DepthForNode(Node<T> node)
        {
            int height = 0;

            for (int i = 0; i < node.children.Count; ++i)
            {
                Node<T> decessor = node.children[i];
                height = Math.Max(height, DepthForNode(decessor) + 1);
            }

            return height;
        }

        public Node<T> FindNode(T value)
        {
            return Node<T>.FindNode(value, root);
        }

        public override string ToString() //writes a tree with bracket notation
        {
            string str = "";

            ToBracketHelper(root, ref str);

            return str;
        }
    }
}
